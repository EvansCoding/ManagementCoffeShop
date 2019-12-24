using ManagementCoffeShop.Core.Interfaces;
using ManagementCoffeShop.Core.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
namespace ManagementCoffeShop.Core.Services
{
    public class DetailBillSellService : IDetailBillSell
    {
        private ICoffeShopContext _context;

        public DetailBillSellService(ICoffeShopContext context)
        {
            _context = context;
        }

        public DetailBillSell CreateDetailBillSell(BillSell billSell, Product product, int number)
        {

            DetailBillSell detailBillSell = new DetailBillSell
            {
                Quantum = number,
                Total = product.priceProduct * number,

            };
            ProductService productService = new ProductService(_context);
            detailBillSell.Product = productService.GetProduct(product);
            BillSellService billSellService = new BillSellService(_context);
            detailBillSell.BillSells = new List<BillSell>() { billSellService.GetBillWithId(billSell.Id) };
            _context.DetailBillSells.Add(detailBillSell);
            _context.SaveChanges();
            return detailBillSell;
        }

        public bool DeleteDetailBillSell(DetailBillSell detailbillSell)
        {
            _context.DetailBillSells.Attach(detailbillSell);
            _context.DetailBillSells.Remove(detailbillSell);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteDetailBillSellAll(BillSell billSell)
        {
            var list = GetDetailBillSell(billSell);
            _context.DetailBillSells.RemoveRange(list);
            return true;
        }
        public List<DetailBillSell> GetAllDetailToBill(DetailBillSell billSell)
        {
            var listDetail = _context.DetailBillSells.Where(x => x.Id == billSell.Id).ToList();
            return listDetail;
        }

        public int GetCountDetail(BillSell billSell)
        {
            return _context.DetailBillSells.Where(x => x.BillSells.Any(r => r.Id == billSell.Id)).Include(x => x.Product).Include(x => x.BillSells).ToList().Sum(x => x.Quantum);
        }

        public decimal GetTolTalDetail(Guid Id)
        {
            return _context.DetailBillSells.Where(x => x.BillSells.Any(r => r.Id == Id)).Include(x => x.Product).Include(x => x.BillSells).ToList().Sum(x => x.Total);
        }

        public List<DetailBillSell> GetDetailBillSell(BillSell billSell)
        {
            var bill = _context.DetailBillSells.Where(x => x.BillSells.Any(r => r.Id == billSell.Id)).Include(x => x.Product).Include(x => x.BillSells).ToList<DetailBillSell>();
            return bill;
        }

        public DetailBillSell GetDetailBill(DetailBillSell detailBillSell)
        {
            return _context.DetailBillSells.Where(x => x.Id == detailBillSell.Id).Include(x => x.BillSells).Include(x => x.Product).SingleOrDefault();
        }

        public void RefreshContext(ICoffeShopContext context)
        {
            _context = context;
        }

        public DataTable dataProduct(string Id)
        {
            Guid idBill = new Guid(Id);
            var list = _context.BillSells.Where(x => x.Id == idBill).Include(x => x.DetailBillSells).SingleOrDefault();
            DataTable dataTable = new DataTable();
            dataTable.Clear();
            dataTable.Columns.Add("nameProduct", typeof(string));
            dataTable.Columns.Add("priceProduct", typeof(string));
            dataTable.Columns.Add("Quantum", typeof(string));
            dataTable.Columns.Add("Total", typeof(string));
            DataRow row;

            ProductService productService = new ProductService(_context);

            foreach (Guid item in list.DetailBillSells.Select(x => x.Id).ToList())
            {
                var detail = GetDetailBillWithID(item);
                row = dataTable.NewRow();
                row[0] = detail.Product.nameProduct;
                row[1] = detail.Product.priceProduct.ToString("N0");
                row[2] = detail.Quantum;
                row[3] = detail.Total.ToString("N0");
                dataTable.Rows.Add(row);
            }
            return dataTable;
        }

        public DetailBillSell GetDetailBillWithID(Guid ID)
        {
            return _context.DetailBillSells.Where(x => x.Id == ID).Include(x => x.Product).Include(x => x.BillSells).SingleOrDefault();
        }
    }
}
