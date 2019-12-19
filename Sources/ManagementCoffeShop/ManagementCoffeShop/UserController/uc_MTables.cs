using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using ManagementCoffeShop.Core.Data.Context;
using ManagementCoffeShop.Core.Services;
using System;
using System.Data;
using System.Windows.Forms;

namespace ManagementCoffeShop.UserController
{
    public partial class uc_MTables : DevExpress.XtraEditors.XtraUserControl
    {
        public uc_MTables()
        {
            InitializeComponent();
        }

        private void uc_MTables_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            btnDelete.Enabled = false;
            TableService tableService = new TableService(new CoffeShopContext());
            gridControl1.DataSource = tableService.GetAllTable();
            AreaService areaService = new AreaService(new CoffeShopContext());

            RepositoryItemComboBox _riEditor = new RepositoryItemComboBox();

            _riEditor.Items.AddRange(areaService.GetAllNameArea());
            gridControl1.RepositoryItems.Add(_riEditor);
            gridView1.Columns[4].ColumnEdit = _riEditor;
            btnDelete.Enabled = false;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            TableService tableService = new TableService(new CoffeShopContext());

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.OK)
            {
                if (tableService.Delete(idTable))
                    MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Thất Bại", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            idTable = "";
            btnDelete.Enabled = false;
            loadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fAddTable fAddTable = new fAddTable();
            fAddTable.ShowDialog();
            loadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable yourDataTable = gridControl1.DataSource as DataTable;
            TableService tableService = new TableService(new CoffeShopContext());

            if (tableService.updateTables(yourDataTable))
                MessageBox.Show("Lưu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Thất Bại", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            loadData();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {

        }

        string idTable = "";

        private void gridView1_Click(object sender, EventArgs e)
        {
            //idTable = (sender as GridView).GetFocusedRowCellValue("Id").ToString();
            btnDelete.Enabled = false;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            idTable = (sender as GridView).GetFocusedRowCellValue("Id").ToString();
            btnDelete.Enabled = true;
        }
    }
}
