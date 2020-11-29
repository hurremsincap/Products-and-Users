using System.Security.Principal;

namespace KafeinCase.Core.CrossCuttingConcerns.Security
{
    public class Principal : GenericPrincipal
    {
        //private string[] _subeler;
        //private string[] _cihazlar;
        //public string _yetkiler;
        private string _moduleRoles;

        public Principal(IIdentity identity, string[] roles, string moduleRoles) : base(identity, roles)
        {
            //_yetkiler = yetkiler;
            //_subeler = subeler;
            //_cihazlar = cihazlar;
            _moduleRoles = moduleRoles;
        }
        //public bool IsInFactory(string factoryId)
        //{
        //    for (int i = 0; i < _factory.Length; i++)
        //    {
        //        if (_factory[i] == factoryId)
        //            return true;
        //    }
        //    return false;
        //}

        public bool IsInModuleRoles(string moduleRole)
        {
            string[] temp = _moduleRoles.Split(',');
            foreach (var item in temp)
            {
                if (item.Contains(moduleRole))
                {
                    return true;
                }
            }
            return false;
        }

        //public bool IsInSube(string sube)
        //{
        //    for (int i = 0; i < _subeler.Length; i++)
        //    {
        //        if (_subeler[i] == sube)
        //            return true;
        //    }
        //    return false;
        //}
        //public bool IsInCihaz(string cihaz)
        //{
        //    for (int i = 0; i < _cihazlar.Length; i++)
        //    {
        //        if (_cihazlar[i] == cihaz)
        //            return true;
        //    }
        //    return false;
        //}


    }

}
