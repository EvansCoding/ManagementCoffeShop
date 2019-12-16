namespace ManagementCoffeShop.Core.Data.Mapping
{
    using Models.Entities;
    using System.Data.Entity.ModelConfiguration;

    public class AreaMapping : EntityTypeConfiguration<Area>
    {
        public AreaMapping()
        {
            HasKey(x => x.Id);
            Property(x => x.Id).IsRequired();
            Property(x => x.nameArea).IsRequired().HasMaxLength(100);
            Property(x => x.Note).IsOptional().HasMaxLength(200);
        }
    }
}
