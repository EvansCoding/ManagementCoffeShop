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
    public partial class uc_AreaVIP : DevExpress.XtraEditors.XtraUserControl
    {
        private static uc_AreaVIP instance;
        public uc_AreaVIP()
        {
            InitializeComponent();
        }

        public static uc_AreaVIP Instance
        {
            get
            {
                if (instance == null) return instance = new uc_AreaVIP();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public void preLoad()
        {
            while (flpAreaVIP.Controls.Count > 0) flpAreaVIP.Controls.RemoveAt(0);

            for (int i = 0; i < 100; i++)
            {
                showClient(i);
            }
        }

        public void showClient(int i)
        {
            uc_Table uS_ShortInfo = new uc_Table(i );
            flpAreaVIP.BeginInvoke((Action)(() =>
            {
                flpAreaVIP.Controls.Add(uS_ShortInfo);
            }));
        }

        private void uc_AreaVIP_Load(object sender, EventArgs e)
        {
            preLoad();
        }
    }
}
