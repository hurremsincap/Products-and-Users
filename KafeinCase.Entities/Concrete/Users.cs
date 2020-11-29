using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KafeinCase.Core.Entities;

namespace KafeinCase.Entities.Concrete
{
    public class Users : IEntity
    {
        public int UserId { get; set; }
        public string Tckn { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string UsersImageUrl { get; set; }

    }
}
