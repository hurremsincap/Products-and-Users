using KafeinCase.Core.CrossCuttingConcerns.Security;
using PostSharp.Aspects;
using System;
using System.Security;

namespace KafeinCase.Core.Aspects.Postsharp.AuthorizationAspects
{
    [Serializable]
    public class AuthenticationOperation : OnMethodBoundaryAspect
    {


        public override void OnEntry(MethodExecutionArgs args)
        {
            string Method = args.Method.Name;
            string Manager = args.Method.DeclaringType.Name;
            if (Method.Equals(".ctor"))
            {
                return;
            }
            bool IsAuthorised = false;

            if (((Principal)System.Threading.Thread.CurrentPrincipal).IsInModuleRoles(Manager + "-" + Method))
            {
                IsAuthorised = true;
            }
            if (IsAuthorised == false)
            {
                throw new SecurityException("You are not authorized!");
            }
        }
    }
}