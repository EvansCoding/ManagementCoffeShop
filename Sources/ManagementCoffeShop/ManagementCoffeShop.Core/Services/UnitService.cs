using ManagementCoffeShop.Core.Interfaces;
using ManagementCoffeShop.Core.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementCoffeShop.Core.Services
{
    public class UnitService : IUnitService
    {
        private ICoffeShopContext _context;

        public UnitService(ICoffeShopContext context)
        {
            _context = context;
        }

        /// <inheritdoc />
        public void RefreshContext(ICoffeShopContext context)
        {
            _context = context;
        }

        public List<string> GetAllName()
        {
            return _context.Units.Select(x => x.nameUnit).ToList();
        }

        public Unit GetName(string name)
        {
            return _context.Units.Where(x => x.nameUnit == name).SingleOrDefault();
        }
    }
}
