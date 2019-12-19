namespace ManagementCoffeShop
{
    using System;
    using System.Windows.Forms;
    using Core.Services;
    using Core.Data.Context;
    using ManagementCoffeShop.Core.Constants;

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
                var user = userService.GetUser(teLogin.Text);
                if(user.userName == Constants.administrator)
                {
                    fMain fMain = new fMain();
                    fMain.Show();
                    return;
                }
                fORDER fORDER = new fORDER(user);
                fORDER.Show();
            }
            else
            {
                MessageBox.Show("Đăng Nhập Không Thành Công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}