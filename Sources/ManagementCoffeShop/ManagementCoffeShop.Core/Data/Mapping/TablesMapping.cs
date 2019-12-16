namespace ManagementCoffeShop.Core.Data.Mapping
{
    using System.Data.Entity.ModelConfiguration;
    using Models.Entities;

    public class TablesMapping : EntityTypeConfiguration<Tables>
    {
        public TablesMapping()
        {
            HasKey(x => x.Id);
            Property(x => x.Id).IsRequired();
            Property(x => x.nameTable).IsRequired().HasMaxLength(100);
            Property(x => x.status).IsRequired();
            Property(x => x.Note).IsOptional().HasMaxLength(200);

            HasRequired(x => x.Area)
                .WithMany(t => t.Tables)
                .Map(x => x.MapKey("Area_Id"))
                .WillCascadeOnDelete(false);

        }
    }
}
