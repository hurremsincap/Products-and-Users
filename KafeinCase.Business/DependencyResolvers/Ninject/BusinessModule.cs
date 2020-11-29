using System.ComponentModel;
using KafeinCase.Business.Abstract;
using KafeinCase.Business.Concrete;
using KafeinCase.DataAccess.Abstract;
using KafeinCase.DataAccess.Concrete.EntityFramework.DataAccessLayer;
using Ninject.Modules;
using KafeinCase.Entities.Concrete;

namespace KafeinCase.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUsersService>().To<UsersManager>().InSingletonScope();
            Bind<IUsersDal>().To<EfUsersDal>();

            Bind<IProductsService>().To<ProductsManager>().InSingletonScope();
            Bind<IProductsDal>().To<EfProductsDal>();

            Bind<IUserProductService>().To<UserProductManager>().InSingletonScope();
            Bind<IUserProductDal>().To<EfUserProductDal>();

        }

    }
}
