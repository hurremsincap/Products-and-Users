using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using KafeinCase.Entities.Concrete;

namespace KafeinCase.Entities.ComplexTypes
{
    public class UserCT
    {
        [Display(Name = "Id")]
        public int UserId { get; set; }
        [Display(Name = "UserName")]
        public string UserName { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "UserSurname")]
        public string Surname { get; set; }
        [Display(Name = "UserPassword")]
        public string Password { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
