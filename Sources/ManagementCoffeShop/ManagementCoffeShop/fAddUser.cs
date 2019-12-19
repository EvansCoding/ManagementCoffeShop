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
    public partial class fAddUser : DevExpress.XtraEditors.XtraForm
    {
        public fAddUser()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void fAddUser_Load(object sender, EventArgs e)
        {
            OfficeService office= new OfficeService(new CoffeShopContext());
            cbbOffice.Properties.Items.AddRange(office.GetAllName());
         
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService(new CoffeShopContext());
            if (userService.Insert(tbUserName.Text, tbPassword.Text, tbFullName.Text, cbbMel.Text, deBirthDay.Text,tbAddress.Text, tbPNumber.Text, tbEmail.Text, cbbOffice.Text    ))
            {
                MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else MessageBox.Show("Thất Bại", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }
    }
}