using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using ManagementCoffeShop.Core.Data.Context;
using ManagementCoffeShop.Core.Services;
using System;
using System.Data;
using System.Windows.Forms;

namespace ManagementCoffeShop.UserController
{
    public partial class uc_MEmploye : DevExpress.XtraEditors.XtraUserControl
    {
        public uc_MEmploye()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            btnDelete.Enabled = false;
            UserService userService = new UserService(new CoffeShopContext());
            gridControl1.DataSource = userService.GetAll();

            OfficeService officeService = new OfficeService(new CoffeShopContext());

            RepositoryItemComboBox _riEditor = new RepositoryItemComboBox();

            _riEditor.Items.AddRange(officeService.GetAllName());
            gridControl1.RepositoryItems.Add(_riEditor);
            gridView1.Columns[11].ColumnEdit = _riEditor;
            btnDelete.Enabled = false;

        }

        private void uc_MEmploye_Load(object sender, EventArgs e)
        {
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fAddUser fAddUser = new fAddUser();
            fAddUser.ShowDialog();
            loadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService(new CoffeShopContext());

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.OK)
            {
                if (userService.Delete(idTable))
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
            UserService userService = new UserService(new CoffeShopContext());

            if (userService.Update(yourDataTable))
                MessageBox.Show("Lưu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Thất Bại", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            loadData();
        }


    }
}
