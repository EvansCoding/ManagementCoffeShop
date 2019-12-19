using ManagementCoffeShop.Core.Interfaces;
using ManagementCoffeShop.Core.Models.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Data.Entity;
using System.Data;

namespace ManagementCoffeShop.Core.Services
{
    public class BillSellService : IBillSellService
    {
        private ICoffeShopContext _context;

        public BillSellService(ICoffeShopContext context)
        {
            _context = context;
        }

        public BillSell CreateBillSell(Employe employe, Customer customer = null, Tables table = null)
        {
            if (customer == null && !table.status)
            {
                CustomerService cust = new CustomerService(_context);
                var _customer = cust.GetCustomer(Constants.Constants.customerDefault);

                BillSell billSell = new BillSell()
                {
                    createDate = DateTime.Now,
                    totalMoney = 0,
                    status = false,
                };
                UserService userService = new UserService(_context);
                billSell.Employe =userService.GetUser(employe);
                TableService tableService = new TableService(_context);
                billSell.Table = tableService.GetTables(table);
                _context.Entry(billSell);
                _context.BillSells.Attach(billSell);

                _context.BillSells.Add(billSell);
                _context.SaveChanges();

                tableService.SetStatusTable(table, true);
                return billSell;
            }
            return null;
        }

        public BillSell GetBillSell(Tables tables)
        {
            return _context.BillSells.Where(x => x.Table.Id == tables.Id && x.status ==false).Include(x=>x.Table).Include(x => x.DetailBillSells).Include(x => x.Employe).OrderByDescending(x => x.createDate).Take(1).SingleOrDefault();
        }

        //public bool DeleteBill()
        public bool DeleteBillSell(BillSell billSell)
        {
            var bil = _context.BillSells.FirstOrDefault(x => x.Id == billSell.Id);
            if(bil != null)
            {
                _context.BillSells.Remove(bil);

                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public DataTable GetAllBill()
        {
            var list =  _context.BillSells.Include(x => x.Employe).Select(x => x).ToList();
            DataTable dataTable = new DataTable();
            dataTable.Clear();
            dataTable.Columns.Add("Id", typeof(string));
            dataTable.Columns.Add("createDate", typeof(string));
            dataTable.Columns.Add("totalMoney", typeof(string));
            dataTable.Columns.Add("status", typeof(bool));
            dataTable.Columns.Add("fullName", typeof(string));
            DataRow row;
            foreach (var item in list)
            {
                row = dataTable.NewRow();
                row[0] = item.Id.ToString();
                row[1] = item.createDate.ToString();
                row[2] = String.Format("{0:0,00} VNĐ", item.totalMoney);
                row[3] = item.status;
                row[4] = item.Employe.fullName;

                dataTable.Rows.Add(row);
            }
            return dataTable;
        }
        
        public BillSell GetBillSellToDetailBill(DetailBillSell detailBillSell)
        {
            return _context.BillSells.FirstOrDefault(x => x.DetailBillSells == detailBillSell);
        }

        public BillSell GetBillWithId(Guid Id)
        {
            return _context.BillSells.Where(x => x.Id == Id).Include(x => x.Table).SingleOrDefault();
        }
        
        public bool SetTotal(List<DetailBillSell> detailBillSells, BillSell billSell)
        {
            decimal total = 0;
            foreach (var item in detailBillSells)
            {
                total += item.Total;
            }

            var bill = _context.BillSells.Where(x => x.Id == billSell.Id).Include(x => x.Employe).Include(x => x.DetailBillSells).Include(x => x.Table).SingleOrDefault();
            bill.totalMoney = total;
            _context.SaveChanges();
            return true;
        }

        public decimal GetTotal(BillSell billSell)
        {
            var bill = _context.BillSells.Where(x => x.Id == billSell.Id).Include(x => x.Employe).Include(x => x.DetailBillSells).Include(x => x.Table).SingleOrDefault();
            return bill.totalMoney;
        }

        public bool setStatus(bool status,BillSell billSell)
        {
            var bill = _context.BillSells.Where(x => x.Id == billSell.Id).Include(x => x.Employe).Include(x => x.DetailBillSells).Include(x => x.Table).SingleOrDefault();

            bill.status = status;
            _context.SaveChanges();
            return true;
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
