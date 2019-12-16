namespace ManagementCoffeShop.Core.Data.Mapping
{
    using System.Data.Entity.ModelConfiguration;
    using Models.Entities;

    public class CustomerMapping : EntityTypeConfiguration<Customer>
    {
        public CustomerMapping()
        {
            HasKey(x => x.Id);
            Property(x => x.Id).IsRequired();
            Property(x => x.nameCustomer).IsRequired().HasMaxLength(100);
            Property(x => x.phoneNumber).IsOptional().HasMaxLength(11);
            Property(x => x.status).IsRequired();
        }
    }
}
