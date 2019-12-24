using ManagementCoffeShop.Core.Interfaces;
using ManagementCoffeShop.Core.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManagementCoffeShop.Core.Services
{
    public class AreaService : IAreaService
    {
        private ICoffeShopContext _context;

        public AreaService(ICoffeShopContext context)
        {
            _context = context;
        }

        public Area GetArea(string nameArea)
        {
            var area = _context.Areas.FirstOrDefault(x => x.nameArea == nameArea);
            return area;
        }

        public List<Area> GetAllArea()
        {
            return _context.Areas.Select(c => c).ToList();
        }

        public List<string> GetAllNameArea()
        {
            return _context.Areas.Select(c => c.nameArea).ToList();
        }
        public bool updateArea(object are)
        {
            try
            {
                List<Area> areas = are as List<Area>;
                foreach (Area item in areas)
                {
                    var some = _context.Areas.Where(x => x.Id == item.Id).SingleOrDefault();
                    some.nameArea = item.nameArea;
                    some.Note = item.Note;
                    _context.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
            }

            return false;
        }

        public bool Insert(string name, string note)
        {
            var area = _context.Areas.Where(x => x.nameArea == name).SingleOrDefault();
            if (area == null)
            {
                Area _area = new Area { nameArea = name, Note = note };
                _context.Areas.Add(_area);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(string Id)
        {
            try
            {
                Guid _id = new Guid(Id);

                var area = _context.Areas.Where(x => x.Id == _id).SingleOrDefault();
                if (area == null) return false;
                _context.Areas.Remove(area);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
            }
            return false;
        }

        public void RefreshContext(ICoffeShopContext context)
        {
            _context = context;
        }

    }
}
