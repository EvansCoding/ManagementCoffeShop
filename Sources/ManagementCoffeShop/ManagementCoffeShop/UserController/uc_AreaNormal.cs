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
using static ManagementCoffeShop.fORDER;

namespace ManagementCoffeShop.UserController
{
    public partial class uc_AreaNormal : DevExpress.XtraEditors.XtraUserControl
    {

        private static uc_AreaNormal instance;
        public uc_AreaNormal()
        {
            InitializeComponent();
            flpAreaNormal.HorizontalScroll.Enabled = false;
        }

        public static uc_AreaNormal Instance
        {
            get
            {
                if (instance == null) return instance = new uc_AreaNormal();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public void preLoad()
        {
            while (flpAreaNormal.Controls.Count > 0) flpAreaNormal.Controls.RemoveAt(0);

            for (int i = 0; i < 50; i++)
            {
                showClient(i);
            }
        }

        public void showClient(int i)
        {
            uc_Table uS_ShortInfo = new uc_Table(i);
            flpAreaNormal.BeginInvoke((Action)(() =>
            {
                flpAreaNormal.Controls.Add(uS_ShortInfo);
            }));
        }

        private void uc_AreaNormal_Load(object sender, EventArgs e)
        {
            preLoad();
        }
    }
}
