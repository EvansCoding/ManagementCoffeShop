namespace ManagementCoffeShop.Core.Data.Mapping
{
    using Models.Entities;
    using System.Data.Entity.ModelConfiguration;
    public class SupplierMapping : EntityTypeConfiguration<Supplier>
    {
        public SupplierMapping()
        {
            HasKey(x => x.Id);
            Property(x => x.Id).IsRequired();
            Property(x => x.nameSupplier).IsRequired().HasMaxLength(100);
            Property(x => x.address).IsRequired().HasMaxLength(100);
            Property(x => x.phoneNumber).IsRequired().HasMaxLength(100);
        }
    }
}
