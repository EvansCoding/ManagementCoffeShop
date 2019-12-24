using System;
using System.Linq;
using System.Windows.Forms;

namespace ManagementCoffeShop.UserController
{
    public partial class uc_EArea : DevExpress.XtraEditors.XtraUserControl
    {
        public uc_EArea()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            fMain f1 = Application.OpenForms.OfType<fMain>().FirstOrDefault();
            f1.SellControlAdd(2);
        }
    }
}
