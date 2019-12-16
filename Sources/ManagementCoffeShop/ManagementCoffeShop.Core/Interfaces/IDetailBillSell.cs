using ManagementCoffeShop.Core.Models.Entities;
using System.Collections.Generic;

namespace ManagementCoffeShop.Core.Interfaces
{
    public interface IDetailBillSell : IContextService
    {
        DetailBillSell CreateDetailBillSell(BillSell billSell, Product product, int number);
        List<DetailBillSell> GetAllDetailToBill(DetailBillSell billSell);
        bool DeleteDetailBillSell(DetailBillSell detailbillSell);
    }
}
