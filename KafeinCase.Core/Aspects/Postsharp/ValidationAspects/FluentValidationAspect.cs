using System;
using System.Linq;
using PostSharp.Aspects;
using KafeinCase.Core.CrossCuttingConcerns.Validation.FluentValidation;
using FluentValidation;

namespace KafeinCase.Core.Aspects.Postsharp.ValidationAspects
{
    [Serializable]
    public class FluentValidationAspect : OnMethodBoundaryAspect
    {
        Type _validatorType;
        public FluentValidationAspect(Type validatorType)
        {

            _validatorType = validatorType;
        }

        public override void OnEntry(MethodExecutionArgs args)
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType);
            var entitiyType = _validatorType.BaseType.GetGenericArguments()[0];
            var entities = args.Arguments.Where(t => t.GetType() == entitiyType);

            foreach (var entity in entities)
            {
                ValidatorTool.FluentValidate(validator, entity);
            }
        }



    }
}
