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
using DevExpress.XtraGrid.Views.Grid;

namespace ManagementCoffeShop.UserController
{
    public partial class uc_MArea : DevExpress.XtraEditors.XtraUserControl
    {
        public uc_MArea()
        {
            InitializeComponent();
        }

        private void uc_MArea_Load(object sender, EventArgs e)
        {
            loadData();
        }

        void loadData()
        {
            AreaService areaService = new AreaService(new CoffeShopContext());
            gridControl1.DataSource = areaService.GetAllArea();
            btnDelete.Enabled = false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            fAddArea fAddTable = new fAddArea();
            fAddTable.ShowDialog();
            loadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            AreaService areaService = new AreaService(new CoffeShopContext());

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.OK)
            {
                if (areaService.Delete(idTable))
                    MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Thất Bại", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            idTable = "";
            btnDelete.Enabled = false;
            loadData();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            object dataTable = gridControl1.DataSource;
            AreaService areaService = new AreaService(new CoffeShopContext());

            if (areaService.updateArea(dataTable))
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
