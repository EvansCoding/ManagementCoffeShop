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
    public partial class fAddSupplier : DevExpress.XtraEditors.XtraForm
    {
        public fAddSupplier()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            SupplierService supplierService = new SupplierService(new CoffeShopContext());
            if (supplierService.Insert(tbName.Text, tbAddress.Text, tbPhone.Text))
            {
                MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else MessageBox.Show("Thất Bại", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}