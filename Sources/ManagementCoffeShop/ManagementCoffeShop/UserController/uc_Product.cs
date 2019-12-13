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
    public partial class uc_Product : DevExpress.XtraEditors.XtraUserControl
    {
        public uc_Product(int i)
        {
            InitializeComponent();
            index = i;
        }
        private int index;
        private void uc_Product_Click(object sender, EventArgs e)
        {
          //  MessageBox.Show("Click in uc: "+ index.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click in uc: " + index.ToString());
        }
    }
}
