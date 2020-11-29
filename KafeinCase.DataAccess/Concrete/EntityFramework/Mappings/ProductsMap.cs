using System.Data.Entity.ModelConfiguration;
using KafeinCase.Entities.Concrete;

namespace KafeinCase.DataAccess.Concrete.EntityFramework.Mappings
{
    public class ProductsMap : EntityTypeConfiguration<Products>
    {
        public ProductsMap()
        {
            ToTable("Products", "dbo");
            HasKey(x => x.ProductId);          
        }
    }
}
