using DevExpress.XtraGrid.Views.Grid;
using ManagementCoffeShop.Core.Data.Context;
using ManagementCoffeShop.Core.Services;
using System;
using System.Windows.Forms;

namespace ManagementCoffeShop.UserController
{
    public partial class uc_MOffice : DevExpress.XtraEditors.XtraUserControl
    {
        public uc_MOffice()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fAddOffice fAddOffice = new fAddOffice();
            fAddOffice.ShowDialog();
            loadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OfficeService officeService = new OfficeService(new CoffeShopContext());

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.OK)
            {
                if (officeService.Delete(idTable))
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
            OfficeService officeService = new OfficeService(new CoffeShopContext());

            if (officeService.Update(dataTable))
                MessageBox.Show("Lưu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Thất Bại", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            loadData();
        }

        void loadData()
        {
            OfficeService officeService = new OfficeService(new CoffeShopContext());
            gridControl1.DataSource = officeService.GetAll();
            btnDelete.Enabled = false;
        }

        private void uc_MOffice_Load(object sender, EventArgs e)
        {
            loadData();
            btnDelete.Enabled = false;
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
