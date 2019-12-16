using ManagementCoffeShop.Core.Interfaces;
using ManagementCoffeShop.Core.Models.Entities;
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
