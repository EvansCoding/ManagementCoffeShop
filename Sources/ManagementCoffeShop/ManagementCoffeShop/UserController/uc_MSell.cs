using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ManagementCoffeShop.Core.Services;
using ManagementCoffeShop.Core.Data.Context;
using ManagementCoffeShop.Report;
using DevExpress.XtraReports.UI;

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
