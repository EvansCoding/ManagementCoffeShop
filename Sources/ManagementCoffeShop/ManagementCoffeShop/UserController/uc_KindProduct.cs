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
using ManagementCoffeShop.Core.Models.Entities;

namespace ManagementCoffeShop.UserController
{
    public partial class uc_KindProduct : DevExpress.XtraEditors.XtraUserControl
    {
        public uc_KindProduct(ProductType _productType)
        {
            InitializeComponent();
            productType = _productType;
        }
        ProductType productType;
        private void uc_KindProduct_Load(object sender, EventArgs e)
        {
            lbNameProductType.Text = productType.nameProductType;
        }

        private void lbNameProductType_MouseClick(object sender, MouseEventArgs e)
        {
            //uc_PanelOrderProducts f1 = Application..OfType<uc_PanelOrderProducts>().FirstOrDefault();
            //if (f1 != null)
            //{
            //    f1.ShowProductToType(productType);
            //}
            uc_PanelOrderProducts.Instance.ShowProductToType(productType);
        }

        private void lbNameProductType_MouseHover(object sender, EventArgs e)
        {
            pnlBelow.BackColor = Color.FromArgb(0, 255, 127);
        }

        private void lbNameProductType_MouseLeave(object sender, EventArgs e)
        {
            pnlBelow.BackColor = Color.White;
        }
    }
}
