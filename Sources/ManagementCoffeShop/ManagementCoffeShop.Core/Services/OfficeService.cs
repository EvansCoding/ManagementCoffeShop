using ManagementCoffeShop.Core.Interfaces;
using ManagementCoffeShop.Core.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementCoffeShop.Core.Services
{
    public class OfficeService : IOfficeService
    {
        private ICoffeShopContext _context;
        public OfficeService(ICoffeShopContext context)
        {
            _context = context;
        }

        public List<Office> GetAll()
        {
            return _context.Offices.Select(x => x).ToList();
        }

        //public List<string> GetAllNameString()
        //{
        //    return _context.Offices.Select(x => x.nameOffice).ToList();
        //}

        public bool Insert(string name)
        {
            var off = _context.Offices.Where(x => x.nameOffice == name).SingleOrDefault();
            if (off == null)
            {
                Office _off = new Office { nameOffice = name, createdDay = DateTime.Now, updatedDay = DateTime.Now };
                _context.Offices.Add(_off);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Update(object off)
        {
            try
            {
                List<Office> offices = off as List<Office>;
                foreach (Office item in offices)
                {
                    var some = _context.Offices.Where(x => x.Id == item.Id).SingleOrDefault();
                    some.nameOffice = item.nameOffice;
                    some.updatedDay = DateTime.Now;
                    _context.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
            }

            return false;
        }

        public bool Delete(string Id)
        {
            try
            {
                Guid _id = new Guid(Id);

                var off = _context.Offices.Where(x => x.Id == _id).SingleOrDefault();
                if (off == null) return false;
                _context.Offices.Remove(off);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
            }
            return false;
        }
        public Office GetOffice(string nameOff)
        {
            var off = _context.Offices.FirstOrDefault(x => x.nameOffice == nameOff);
            return off;
        }

        public List<string> GetAllName()
        {
            return _context.Offices.Select(x => x.nameOffice).ToList();
        }
        /// <inheritdoc />
        public void RefreshContext(ICoffeShopContext context)
        {
            _context = context;
        }
    }
}
