using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ManagementCoffeShop.UserController;
using DevExpress.Utils.Extensions;
using ManagementCoffeShop.Classes;

namespace ManagementCoffeShop
{
    public partial class fORDER : DevExpress.XtraEditors.XtraForm
    {
        private static fORDER instance;
        public static fORDER Instance
        {
            get
            {
                if (instance == null) return instance = new fORDER();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        #region INITIALIZE
        public fORDER()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        #endregion

        #region METHODS
        public void orderProducts(int i)
        {
            myControls.Instance.addCotrolTableToOrder(uc_PanelOrderProducts.Instance, pnlControl);
        }

        public void returnUC_PanelTables()
        {
            myControls.Instance.addCotrolTableToOrder(uc_PanelTables.Instance, pnlControl);
        }
        #endregion

        #region EVENTS

        private void fORDER_Load(object sender, EventArgs e)
        {
            myControls.Instance.addCotrolTableToOrder(uc_PanelTables.Instance, pnlControl);
        }
        bool check = true;

        private void fORDER_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11 && check)
            {
                FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                check = false;
            }
            else
            {
                if (e.KeyCode == Keys.F11 && !check)
                {
                    FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
                    WindowState = FormWindowState.Normal;
                    check = true;
                }
            }
        }
        #endregion
    }
}