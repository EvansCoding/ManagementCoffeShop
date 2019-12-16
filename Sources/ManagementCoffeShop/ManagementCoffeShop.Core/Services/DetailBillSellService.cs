using ManagementCoffeShop.Core.Interfaces;
using ManagementCoffeShop.Core.Models.Entities;
using System.Collections.Generic;
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

        public int  GetCountDetail(BillSell billSell)
        {
            return _context.DetailBillSells.Where(x => x.BillSells.Any(r => r.Id == billSell.Id)).Include(x => x.Product).Include(x => x.BillSells).ToList().Sum(x => x.Quantum);
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
    }
}
