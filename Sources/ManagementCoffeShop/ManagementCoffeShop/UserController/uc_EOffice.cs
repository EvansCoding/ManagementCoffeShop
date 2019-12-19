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
