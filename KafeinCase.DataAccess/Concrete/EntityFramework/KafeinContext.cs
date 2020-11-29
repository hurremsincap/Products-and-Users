using System.Data.Entity;
using KafeinCase.DataAccess.Concrete.EntityFramework.Mappings;
using KafeinCase.Entities.Concrete;


namespace KafeinCase.DataAccess.Concrete.EntityFramework
{
    public class KafeinContext : DbContext
    {
        public KafeinContext()
        {
            Database.SetInitializer<KafeinContext>(null);
        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<UserProduct> UserProduct { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {           
            modelBuilder.Configurations.Add(new UsersMap());
            modelBuilder.Configurations.Add(new ProductsMap());
            modelBuilder.Configurations.Add(new UserProductMap());
        }
    }
}