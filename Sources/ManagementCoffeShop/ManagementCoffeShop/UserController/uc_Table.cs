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
using DevExpress.Utils.Extensions;
using ManagementCoffeShop.Classes;

namespace ManagementCoffeShop.UserController
{
    public partial class uc_Table : DevExpress.XtraEditors.XtraUserControl
    {

        public uc_Table(int i)
        {
            InitializeComponent();
            index = i;
            // this.r = sender;
            CheckForIllegalCrossThreadCalls = false;
        }

        private int index;

        private void uc_Table_Load(object sender, EventArgs e)
        {
            label1.Text = index.ToString();
        }

        private void uc_Table_Click(object sender, EventArgs e)
        {

            label1.BackColor = Color.LightYellow;
        }

        private void label1_Click(object sender, EventArgs e)
        {

            label1.BackColor = Color.FromArgb(246, 205, 91);

        }

        private void orderProduct_Click(object sender, EventArgs e)
        {
            fORDER f1 = Application.OpenForms.OfType<fORDER>().FirstOrDefault();
            if (f1 != null)
            {
                f1.orderProducts(1);
            }
        }

    }
}
