namespace ManagementCoffeShop.Core.Data.Mapping
{
    using Models.Entities;
    using System.Data.Entity.ModelConfiguration;

    public class DetailBillSellMapping : EntityTypeConfiguration<DetailBillSell>
    {
        public DetailBillSellMapping()
        {
            HasKey(x => x.Id);
            Property(x => x.Id).IsRequired();
            Property(x => x.Quantum).IsRequired();
            Property(x => x.Total).IsRequired();

            HasRequired(x => x.Product)
                .WithMany(t => t.DetailBillSells)
                .Map(x => x.MapKey("Product_Id"))
                .WillCascadeOnDelete(false);

           // join many to many Table BillSell to DetailBillSell
            HasMany(x => x.BillSells)
                .WithMany(t => t.DetailBillSells)
                .Map(m =>
                {
                    m.ToTable("Bill_DetailBill");
                    m.MapLeftKey("DetailBillSell_Id");
                    m.MapRightKey("BillSell_Id");
                });
        }
    }
}
