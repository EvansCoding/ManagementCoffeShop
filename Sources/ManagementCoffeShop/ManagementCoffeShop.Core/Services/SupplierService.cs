using ManagementCoffeShop.Core.Interfaces;
using ManagementCoffeShop.Core.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManagementCoffeShop.Core.Services
{
    public class SupplierService : ISupplierService
    {
        private ICoffeShopContext _context;

        public SupplierService(ICoffeShopContext context)
        {
            _context = context;
        }

        public List<Supplier> GetALl()
        {
            return _context.Suppliers.Select(x => x).ToList();
        }

        public bool Delete(string Id)
        {
            try
            {
                Guid _id = new Guid(Id);
                var sup = _context.Suppliers.Where(x => x.Id == _id).SingleOrDefault();
                if (sup == null) return false;
                _context.Suppliers.Remove(sup);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
            }
            return false;
        }
        public bool Update(object sup)
        {
            try
            {
                List<Supplier> sups = sup as List<Supplier>;
                foreach (Supplier item in sups)
                {
                    var some = _context.Suppliers.Where(x => x.Id == item.Id).SingleOrDefault();
                    some.nameSupplier = item.nameSupplier;
                    some.address = item.address;
                    some.phoneNumber = item.phoneNumber;
                    _context.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
            }
            return false;
        }

        public bool Insert(string name, string address, string phoneNb)
        {
            try
            {
                Supplier sup = new Supplier
                {
                    nameSupplier = name,
                    address = address,
                    phoneNumber = phoneNb
                };
                _context.Suppliers.Add(sup);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
            }
            return false;
        }
        /// <inheritdoc />
        public void RefreshContext(ICoffeShopContext context)
        {
            _context = context;
        }
    }
}
