namespace ManagementCoffeShop.Core.Data.Mapping
{
    using Models.Entities;
    using System.Data.Entity.ModelConfiguration;
    public class UnitMapping : EntityTypeConfiguration<Unit>
    {
        public UnitMapping()
        {
            HasKey(x => x.Id);
            Property(x => x.Id).IsRequired();
            Property(x => x.nameUnit).IsRequired().HasMaxLength(200);

        }
    }
}
