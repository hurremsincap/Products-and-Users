using System.Data.Entity.ModelConfiguration;
using KafeinCase.Entities.Concrete;

namespace KafeinCase.DataAccess.Concrete.EntityFramework.Mappings
{
    public class UsersMap : EntityTypeConfiguration<Users>
    {
        public UsersMap()
        {
            ToTable("Users", "dbo");
            HasKey(x => x.UserId);          
        }
    }
}
