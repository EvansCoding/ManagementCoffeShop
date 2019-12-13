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

        int SaveChanges();
        Task<int> SaveChangesAsync();
        void RollBack();
    }
}
