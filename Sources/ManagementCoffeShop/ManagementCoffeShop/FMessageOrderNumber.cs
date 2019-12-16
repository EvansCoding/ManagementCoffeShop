using ManagementCoffeShop.Core.Data.Context;
using ManagementCoffeShop.Core.Models.Entities;
using ManagementCoffeShop.Core.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ManagementCoffeShop
{
    public partial class FMessageOrderNumber : DevExpress.XtraEditors.XtraForm
    {
        public FMessageOrderNumber(Product product)
        {
            InitializeComponent();
            _product = product;
        }
        Product _product;
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            bool check = true;
            fORDER f1 = Application.OpenForms.OfType<fORDER>().FirstOrDefault();
            if (f1 != null)
            {
                try
                {
                    BillSell billSell = f1.getBillSellofTable();
                    DetailBillSellService detailBillSellService = new DetailBillSellService(new CoffeShopContext());
                    int number = Convert.ToInt32(cbbNumber.SelectedItem);
                    var DetailBillSell = detailBillSellService.CreateDetailBillSell(billSell, _product, number);
                    var DetailBill = detailBillSellService.GetDetailBill(DetailBillSell);
                    f1.addProductToListOrder(DetailBill);
                    f1.lbCount.Text = detailBillSellService.GetCountDetail(billSell).ToString();
                    BillSellService bsService = new BillSellService(new CoffeShopContext());
                    bsService.SetTotal(detailBillSellService.GetDetailBillSell(billSell), billSell);
                    f1.lbTotal.Text = String.Format("{0:0,00} VNĐ", bsService.GetTotal(billSell));

                }
                catch (Exception)
                {
                    cbbNumber.Refresh();
                    check = false;
                }
            }
            if (check)
                this.Dispose();
        }

    }
}
