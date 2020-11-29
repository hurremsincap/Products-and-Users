using System.Data.Entity.ModelConfiguration;
using KafeinCase.Entities.Concrete;

namespace KafeinCase.DataAccess.Concrete.EntityFramework.Mappings
{
    public class UserProductMap : EntityTypeConfiguration<UserProduct>
    {
        public UserProductMap()
        {
            ToTable("UserProduct", "dbo");
            HasKey(x => x.UserProductId);          
        }
    }
}
