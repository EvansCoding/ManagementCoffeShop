using ManagementCoffeShop.Core.Data.Context;
using ManagementCoffeShop.Core.Services;
using System;
using System.Windows.Forms;

namespace ManagementCoffeShop
{
    public partial class fAddOffice : DevExpress.XtraEditors.XtraForm
    {
        public fAddOffice()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OfficeService areaService = new OfficeService(new CoffeShopContext());
            if (areaService.Insert(tbNameTable.Text))
            {
                MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else MessageBox.Show("Thất Bại", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}