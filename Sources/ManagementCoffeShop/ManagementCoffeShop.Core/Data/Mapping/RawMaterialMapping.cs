namespace ManagementCoffeShop.Core.Data.Mapping
{
    using Models.Entities;
    using System.Data.Entity.ModelConfiguration;
    public class RawMaterialMapping : EntityTypeConfiguration<RawMaterial>
    {
        public RawMaterialMapping()
        {
            HasKey(x => x.Id);
            Property(x => x.Id).IsRequired();
            Property(x => x.nameRawMaterial).IsRequired().HasMaxLength(100);
            Property(x => x.priceRawMaterial).IsRequired();
            Property(x => x.InventoryNumber).IsRequired();

            HasRequired(x => x.Unit)
                .WithMany(t => t.RawMaterials)
                .Map(x => x.MapKey("Unit_Id"))
                .WillCascadeOnDelete(false);

            // Many-to-Many join talbe - a RawMaterial may belong to many Supplier
            HasMany(t => t.Suppliers)
                .WithMany(t => t.RawMaterials)
                .Map(m =>{
                    m.ToTable("DetailRawMaterial");
                    m.MapLeftKey("RawMaterial_Id");
                    m.MapRightKey("Supplier_Id");
            });
        }
    }
}
