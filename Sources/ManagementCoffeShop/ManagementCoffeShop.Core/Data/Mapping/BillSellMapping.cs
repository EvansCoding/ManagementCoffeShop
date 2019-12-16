namespace ManagementCoffeShop.Core.Data.Mapping
{
    using System.Data.Entity.ModelConfiguration;
    using Models.Entities;

    public class BillSellMapping :EntityTypeConfiguration<BillSell>
    {
        public BillSellMapping()
        {
            HasKey(x => x.Id);
            Property(x => x.Id).IsRequired();
            Property(x => x.createDate).IsRequired();
            Property(x => x.totalMoney).IsRequired();
            Property(x => x.status).IsRequired();

            //HasRequired(x => x.Customer)
            //    .WithMany(t => t.BillSells)
            //    .Map(x => x.MapKey("Customer_Id"))
            //    .WillCascadeOnDelete(false);

            HasRequired(x => x.Employe)
                .WithMany(t => t.BillSells)
                .Map(x => x.MapKey("Employe_Id"))
                .WillCascadeOnDelete(false);

            HasRequired(x => x.Table)
                .WithMany(t => t.BillSells)
                .Map(x => x.MapKey("Table_Id"))
                .WillCascadeOnDelete(false);
        }
    }
}
