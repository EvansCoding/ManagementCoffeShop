using ManagementCoffeShop.Core.Data.Context;
using ManagementCoffeShop.Core.Services;
using System;

namespace ManagementCoffeShop.UserController
{
    public partial class uc_MSell : DevExpress.XtraEditors.XtraUserControl
    {
        public uc_MSell()
        {
            InitializeComponent();
        }

        private void uc_MSell_Load(object sender, EventArgs e)
        {
            BillSellService billSellService = new BillSellService(new CoffeShopContext());
            gridControl1.DataSource = billSellService.GetAllBill();
        }



        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {
            BillSellService billSellService = new BillSellService(new CoffeShopContext());
            gridControl1.DataSource = billSellService.GetBillTime(dateEdit1.DateTime);
        }
    }
}
