using ManagementCoffeShop.Core.Data.Context;
using ManagementCoffeShop.Core.Services;
using System;
using System.Windows.Forms;

namespace ManagementCoffeShop
{
    public partial class fAddArea : DevExpress.XtraEditors.XtraForm
    {
        public fAddArea()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            AreaService areaService = new AreaService(new CoffeShopContext());
            if (areaService.Insert(tbNameTable.Text, tbNote.Text))
            {
                MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else MessageBox.Show("Thất Bại", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }
    }
}