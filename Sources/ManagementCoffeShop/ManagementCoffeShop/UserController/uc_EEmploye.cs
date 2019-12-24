using System;
using System.Linq;
using System.Windows.Forms;

namespace ManagementCoffeShop.UserController
{
    public partial class uc_EEmploye : DevExpress.XtraEditors.XtraUserControl
    {
        public uc_EEmploye()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            fMain f1 = Application.OpenForms.OfType<fMain>().FirstOrDefault();
            f1.SellControlAdd(5);
        }
    }
}
