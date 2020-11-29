using System.Collections.Generic;
using KafeinCase.Business.Abstract;
using KafeinCase.DataAccess.Abstract;
using KafeinCase.Entities.Concrete;

namespace KafeinCase.Business.Concrete
{
    public class UsersManager : IUsersService
    {
        private IUsersDal _usersDal;

        public UsersManager(IUsersDal usersDal)
        {
            _usersDal = usersDal;
        }
        public List<Users> GetAll()
        {
            return _usersDal.GetList();
        }
       
    }
}
