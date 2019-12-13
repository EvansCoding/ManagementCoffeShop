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
using ManagementCoffeShop.Core;
using ManagementCoffeShop.Core.Services;
using ManagementCoffeShop.Core.Data.Context;

namespace ManagementCoffeShop
{
    public partial class fLogin : DevExpress.XtraEditors.XtraForm
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService(new CoffeShopContext());
            if(userService.ValidateUser(teLogin.Text, tePassword.Text))
            {
                this.Hide();
                fORDER.Instance.Show();
            }
            else
            {
                MessageBox.Show("Đăng Nhập Không Thành Công");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}