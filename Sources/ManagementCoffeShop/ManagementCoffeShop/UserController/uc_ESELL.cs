using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ManagementCoffeShop.UserController
{
    public partial class uc_ESELL : DevExpress.XtraEditors.XtraUserControl
    {
        public uc_ESELL()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            fMain f1 = Application.OpenForms.OfType<fMain>().FirstOrDefault();
            f1.SellControlAdd(1);
        }
    }
}
