namespace ManagementCoffeShop.Core.Data.Mapping
{
    using Models.Entities;
    using System.Data.Entity.ModelConfiguration;

    public class ProductMapping : EntityTypeConfiguration<Product>
    {
        public ProductMapping()
        {
            HasKey(x => x.Id);
            Property(x => x.Id).IsRequired();
            Property(x => x.nameProduct).IsRequired().HasMaxLength(100);
            Property(x => x.pathImage).IsRequired().HasMaxLength(100);
            Property(x => x.priceProduct).IsRequired();

            HasRequired(x => x.Unit)
                .WithMany(t => t.Products)
                .Map(t => t.MapKey("Unit_Id"))
                .WillCascadeOnDelete(false);


            HasRequired(x => x.ProductType)
                .WithMany(t => t.Products)
                .Map(x => x.MapKey("ProductType_Id"))
                .WillCascadeOnDelete(false);
        }
    }
}
