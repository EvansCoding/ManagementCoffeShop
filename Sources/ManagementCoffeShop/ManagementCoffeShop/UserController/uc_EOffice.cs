using System;
using System.Linq;
using System.Windows.Forms;

namespace ManagementCoffeShop.UserController
{
    public partial class uc_EOffice : DevExpress.XtraEditors.XtraUserControl
    {
        public uc_EOffice()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            fMain f1 = Application.OpenForms.OfType<fMain>().FirstOrDefault();
            f1.SellControlAdd(6);
        }
    }
}
