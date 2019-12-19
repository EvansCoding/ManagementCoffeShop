using ManagementCoffeShop.Core.Data.Context;
using ManagementCoffeShop.Core.Services;
using System;
using System.Windows.Forms;

namespace ManagementCoffeShop
{
    public partial class fAddTable : DevExpress.XtraEditors.XtraForm
    {
        public fAddTable()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            TableService tableService = new TableService(new CoffeShopContext());
            if (tableService.Insert(tbNameTable.Text, cbbArea.Text))
            {
                MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else MessageBox.Show("Thất Bại", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void fAddTable_Load(object sender, EventArgs e)
        {
            AreaService areaService = new AreaService(new CoffeShopContext());

            cbbArea.Properties.Items.AddRange(areaService.GetAllNameArea());
        }
    }
}