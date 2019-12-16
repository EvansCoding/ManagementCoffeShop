namespace ManagementCoffeShop.Core.Services
{
    using ManagementCoffeShop.Core.Interfaces;
    using ManagementCoffeShop.Core.Models.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class TableService : ITableService
    {
        private ICoffeShopContext _context;
        public TableService(ICoffeShopContext context)
        {
            _context = context;
        }

        public List<Tables> GetTables(Area area)
        {
            var listTableNOR = _context.Tables.Where(x => x.Area.Id == area.Id).Include(t => t.BillSells).ToList();
            return listTableNOR;
        }

        public Tables GetTables(Tables tables)
        {
            return _context.Tables.Where(x => x.Id == tables.Id).Include(x => x.BillSells).Include(x => x.Area).SingleOrDefault();
        }

        public bool SetStatusTable(Tables tables, bool status)
        {
            try
            {
                var table = _context.Tables.FirstOrDefault(x => x.Id == tables.Id);
                table.status = status;
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
            }
            return false;
        }

        public Tables GetTables(BillSell billSell)
        {
            return _context.Tables.Where(x => x.Id == billSell.Table.Id).Include(x => x.BillSells).SingleOrDefault();
        }
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
