namespace ManagementCoffeShop.Core.Data.Mapping
{
    using Models.Entities;
    using System.Data.Entity.ModelConfiguration;

    public class OfficeMapping : EntityTypeConfiguration<Office>
    {
        public OfficeMapping()
        {
            HasKey(x => x.Id);
            Property(x => x.Id).IsRequired();
            Property(x => x.createdDay).IsRequired();
            Property(x => x.updatedDay).IsRequired();
        }
    }
}
