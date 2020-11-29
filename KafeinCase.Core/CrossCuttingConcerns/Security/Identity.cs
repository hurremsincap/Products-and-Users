using System;
using System.Security.Principal;

namespace KafeinCase.Core.CrossCuttingConcerns.Security
{
    public class Identity : IIdentity
    {
        public string AuthenticationType { get; set; }

        public bool IsAuthenticated { get; set; }

        public string Name { get; set; }

        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public int UserId { get; set; }
        public string Email { get; set; }
        public string[] Roles { get; set; }
        public string ModuleRoles { get; set; }
    }
}
