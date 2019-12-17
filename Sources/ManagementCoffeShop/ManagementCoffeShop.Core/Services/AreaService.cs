using ManagementCoffeShop.Core.Interfaces;
using ManagementCoffeShop.Core.Models.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public void updateArea(object are)
        {
            List<Area> areas = are as List<Area>;
            foreach (Area item in areas)
            {
                var some = _context.Areas.Where(x => x.Id == item.Id).SingleOrDefault();
                some.nameArea = item.nameArea;
                some.Note = item.Note;
                _context.SaveChanges();
            }
        
        }
        //public Area GetAreaWith(Tables tables)
        //{
        //    //var area = _context.Areas.FirstOrDefault(x => x.Tables. == tables);
        //    //return area;
        //}
        /// <inheritdoc />
        public void RefreshContext(ICoffeShopContext context)
        {
            _context = context;
        }

        /// <inheritdoc />
        //public async Task<int> SaveChanges()
        //{
        //    return await _context.SaveChangesAsync();
        //}
    }
}
