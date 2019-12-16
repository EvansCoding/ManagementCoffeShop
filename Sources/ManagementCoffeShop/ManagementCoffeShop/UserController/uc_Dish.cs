using ManagementCoffeShop.Core.Data.Context;
using ManagementCoffeShop.Core.Models.Entities;
using ManagementCoffeShop.Core.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ManagementCoffeShop.UserController
{
    public partial class uc_Dish : DevExpress.XtraEditors.XtraUserControl
    {
        public uc_Dish(DetailBillSell detailBillSell)
        {
            InitializeComponent();
            _DetailBillSell = detailBillSell;
            this.Name = _DetailBillSell.Id.ToString();
        }

        DetailBillSell _DetailBillSell;

        private void uc_Dish_Load(object sender, EventArgs e)
        {
            if (fORDER.checkStatus)
                btnDelete.Enabled = false;
            else
                btnDelete.Enabled = true;
            lbNumber.Text = _DetailBillSell.Quantum.ToString();
            lbName.Text = _DetailBillSell.Product.nameProduct;
            string price = String.Format("x {0:0,00} VNĐ", _DetailBillSell.Product.priceProduct);
            lbPrice.Text = price;
            string total = String.Format(" {0:0,00} VNĐ", _DetailBillSell.Quantum * _DetailBillSell.Product.priceProduct);
            lbTotal.Text = total;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DetailBillSellService detailBillSell = new DetailBillSellService(new CoffeShopContext());
            detailBillSell.DeleteDetailBillSell(_DetailBillSell);
            this.Controls.Remove(this);
            fORDER f1 = Application.OpenForms.OfType<fORDER>().FirstOrDefault();
            if (f1 != null)
            {
                f1.refreshFLPOrdered(_DetailBillSell);
                reloadProductOrder(_DetailBillSell);
            }
        }

        private void reloadProductOrder(DetailBillSell detailBillSell)
        {
            fORDER f1 = Application.OpenForms.OfType<fORDER>().FirstOrDefault();
            if (f1 != null)
            {
                if (fORDER.staticBill != null)
                    f1.loadInfoOrder(fORDER.staticBill);

            }
        }

    }
}
