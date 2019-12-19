using DevExpress.XtraGrid.Views.Grid;
using ManagementCoffeShop.Core.Data.Context;
using ManagementCoffeShop.Core.Services;
using System;
using System.Windows.Forms;

namespace ManagementCoffeShop.UserController
{
    public partial class uc_MSupplier : DevExpress.XtraEditors.XtraUserControl
    {
        public uc_MSupplier()
        {
            InitializeComponent();
        }
        private void uc_MSupplier_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            SupplierService supplierService = new SupplierService(new CoffeShopContext());
            gridControl1.DataSource = supplierService.GetALl();
            btnDelete.Enabled = false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            fAddSupplier fAddSupplier = new fAddSupplier();
            fAddSupplier.ShowDialog();
            loadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SupplierService supplierService = new SupplierService(new CoffeShopContext());

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.OK)
            {
                if (supplierService.Delete(idTable))
                    MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Thất Bại", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            idTable = "";
            btnDelete.Enabled = false;
            loadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            object dataTable = gridControl1.DataSource;
            SupplierService supplierService = new SupplierService(new CoffeShopContext());
            
            if (supplierService.Update(dataTable))
                MessageBox.Show("Lưu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Thất Bại", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            loadData();
        }


        string idTable = "";
        private void gridView1_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            idTable = (sender as GridView).GetFocusedRowCellValue("Id").ToString();
            btnDelete.Enabled = true;
        }
    }
}
