using ManagementCoffeShop.Core.Models.Entities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ManagementCoffeShop.UserController
{
    public partial class uc_Product : DevExpress.XtraEditors.XtraUserControl
    {
        public uc_Product(Product _product)
        {
            InitializeComponent();
            product = _product;
        }
        private Product product;
        private void uc_Product_Click(object sender, EventArgs e)
        {

        }

        private void uc_Product_Load(object sender, EventArgs e)
        {
            Image image = Image.FromFile(Application.StartupPath + "\\Images\\" + product.pathImage + ".png");

            btnImage.BackgroundImage = image; ;
            decimal price = product.priceProduct / (decimal)1000.0;
            lbPrice.Text = price.ToString(".") + " K";
            lbName.Text = product.nameProduct.ToString();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            FMessageOrderNumber fMessage = new FMessageOrderNumber(product);
            fMessage.ShowDialog();
        }
    }
}
