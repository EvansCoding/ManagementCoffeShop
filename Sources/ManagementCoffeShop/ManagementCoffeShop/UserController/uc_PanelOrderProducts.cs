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
    public partial class uc_PanelOrderProducts : DevExpress.XtraEditors.XtraUserControl
    {

        private static uc_PanelOrderProducts instance;
        public static uc_PanelOrderProducts Instance
        {
            get
            {
                if (instance == null) return instance = new uc_PanelOrderProducts();
                return instance;
            }
            private set
            {
                instance = value;
            }

        }
        public uc_PanelOrderProducts()
        {
            InitializeComponent();
        }



        public void showClient(int i)
        {

            uc_KindProduct uS_ShortInfo = new uc_KindProduct();
            flpKindProducts.BeginInvoke((Action)(() =>
            {
                flpKindProducts.Controls.Add(uS_ShortInfo);
            }));
        }

        private void uc_PanelOrderProducts_Load(object sender, EventArgs e)
        {
              preLoad();
        }

        public void preLoad()
        {
            while (flpKindProducts.Controls.Count > 0) flpKindProducts.Controls.RemoveAt(0);

            for (int i = 0; i < 50; i++)
            {
                showClient(i);
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            fORDER f1 = Application.OpenForms.OfType<fORDER>().FirstOrDefault();
            if (f1 != null)
            {
                f1.returnUC_PanelTables();
            }
        }
    }
}
