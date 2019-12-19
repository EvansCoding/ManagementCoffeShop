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
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;

namespace ManagementCoffeShop.UserController
{
    public partial class uc_MProduct : DevExpress.XtraEditors.XtraUserControl
    {
        public uc_MProduct()
        {
            InitializeComponent();
        }

        private void uc_MProduct_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            btnDelete.Enabled = false;
            ProductTypeService productTypeService = new ProductTypeService(new CoffeShopContext());
            UnitService unitService = new UnitService(new CoffeShopContext());
            ProductService productService = new ProductService(new CoffeShopContext());
            gridControl1.DataSource = productService.GetAllProduct();
           // AreaService areaService = new AreaService(new CoffeShopContext());

            RepositoryItemComboBox productType = new RepositoryItemComboBox();


            productType.Items.AddRange(productTypeService.GetAllName());
            gridControl1.RepositoryItems.Add(productType);
            gridView1.Columns[4].ColumnEdit = productType;

            RepositoryItemComboBox unit = new RepositoryItemComboBox();
            unit.Items.AddRange(unitService.GetAllName());
            gridControl1.RepositoryItems.Add(unit);
            gridView1.Columns[5].ColumnEdit = unit;
            btnDelete.Enabled = false;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fAddProduct fAddProduct = new fAddProduct();
            fAddProduct.ShowDialog();
            loadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ProductService productService = new ProductService(new CoffeShopContext());

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.OK)
            {
                if (productService.Delete(idTable))
                    MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Thất Bại", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            idTable = "";
            btnDelete.Enabled = false;
            loadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable yourDataTable = gridControl1.DataSource as DataTable;
            ProductService productService = new ProductService(new CoffeShopContext());

            if (productService.updateProduct(yourDataTable))
                MessageBox.Show("Lưu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Thất Bại", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            loadData();
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
        }
        string idTable = "";
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            idTable = (sender as GridView).GetFocusedRowCellValue("Id").ToString();
            btnDelete.Enabled = true;
        }
    }
}
