using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ManagementCoffeShop.Core.Services;
using ManagementCoffeShop.Core.Data.Context;

namespace ManagementCoffeShop
{
    public partial class fAddProduct : DevExpress.XtraEditors.XtraForm
    {
        public fAddProduct()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            ProductService productService = new ProductService(new CoffeShopContext());
            if (productService.Insert(tbName.Text, tbPrice.Text, tbPathImage.Text, cbbUnit.Text, cbbProductType.Text))
            {
                MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else MessageBox.Show("Thất Bại", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void fAddProduct_Load(object sender, EventArgs e)
        {
            ProductTypeService productTypeService = new ProductTypeService(new CoffeShopContext());

            cbbProductType.Properties.Items.AddRange(productTypeService.GetAllName());


            UnitService unitService = new UnitService(new CoffeShopContext());

            cbbUnit.Properties.Items.AddRange(unitService.GetAllName());
        }


        private void tbPathImage_Properties_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            string pathImage = "";
            pathImage = f.ShowDialog() == DialogResult.OK ? f.FileName : "";
            tbPathImage.Text = pathImage;
        }
    }
}