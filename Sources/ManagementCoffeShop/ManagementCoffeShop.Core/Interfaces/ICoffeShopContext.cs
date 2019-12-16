namespace ManagementCoffeShop.Core.Interfaces
{
    using ManagementCoffeShop.Core.Models.Entities;
    using System;
    using System.Data.Entity;
    using System.Threading.Tasks;

    public interface ICoffeShopContext : IDisposable
    {
        DbSet<Employe> Employes { get; set; }
        DbSet<Office> Offices { get; set; }
        DbSet<Area> Areas { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<ProductType> ProductTypes { get; set; }
        DbSet<RawMaterial> RawMaterials { get; set; }
        DbSet<Supplier> Suppliers { get; set; }
        DbSet<Tables> Tables { get; set; }
        DbSet<Unit> Units { get; set; }
        DbSet<BillSell> BillSells { get; set; }
        DbSet<Customer> Customers { get; set; }
        DbSet<DetailBillSell> DetailBillSells { get; set; }
     //   DbSet<Bill_DetailBill> Bill_DetailBills { get; set; }

        int SaveChanges();
        //Task<int> SaveChangesAsync();
        void RollBack();
        void Entry(object entry);
    }
}
