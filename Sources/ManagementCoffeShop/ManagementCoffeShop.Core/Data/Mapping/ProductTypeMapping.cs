namespace ManagementCoffeShop.Core.Data.Mapping
{
    using Models.Entities;
    using System.Data.Entity.ModelConfiguration;
    public class ProductTypeMapping : EntityTypeConfiguration<ProductType>
    {
        public ProductTypeMapping()
        {
            HasKey(x => x.Id);
            Property(x => x.Id).IsRequired();
            Property(x => x.nameProductType);
        }
    }
}
