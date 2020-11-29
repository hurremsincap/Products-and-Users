using System;
using PostSharp.Aspects;
using KafeinCase.Core.CrossCuttingConcerns.Logging.Log4Net;
using System.Reflection;

namespace KafeinCase.Core.Aspects.Postsharp.ExceptionAspects
{
    [Serializable]
    public class ExceptionLogAspect : OnExceptionAspect
    {
        [NonSerialized]
        private LoggerService _loggerService;
        private readonly Type _loggerType;

        public ExceptionLogAspect(Type loggerType = null)
        {
            _loggerType = loggerType;

        }

        public override void RuntimeInitialize(MethodBase method)
        {

            if (_loggerType != null)
            {
                if (_loggerType.BaseType != typeof(LoggerService))
                {
                    throw new Exception("Wrong Logger Type");
                }
                _loggerService = (LoggerService)Activator.CreateInstance(_loggerType, Type.EmptyTypes);

            }


            base.RuntimeInitialize(method);
        }

        public override void OnException(MethodExecutionArgs args)
        {
            if (_loggerService != null)
            {
                _loggerService.Error(args.Exception);
            }
        }
    }
}
