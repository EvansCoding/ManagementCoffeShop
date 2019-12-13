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
    public partial class uc_PanelTables : DevExpress.XtraEditors.XtraUserControl
    {
        private static uc_PanelTables instance;
        public uc_PanelTables()
        {
            InitializeComponent();
        }

        public static uc_PanelTables Instance
        {
            get
            {
                if (instance == null) return instance = new uc_PanelTables();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public void hideUC()
        {
            this.Hide();
        }

        private void uc_Tables_Load(object sender, EventArgs e)
        {
            fristLoad();
        }

        private void fristLoad()
        {
            btnAreaNormal.BackColor = Color.White;
            btnAreaNormal.ForeColor = Color.FromArgb(10, 113, 184);
            btnAreaVIP.BackColor = Color.FromArgb(10, 113, 184);
            btnAreaVIP.ForeColor = Color.White;
            addControlsPanel(uc_AreaNormal.Instance);
            addControlsPanel(uc_AreaVIP.Instance);

        }
        private void btnAreaNormal_Click(object sender, EventArgs e)
        {
            btnAreaNormal.BackColor = Color.White;
            btnAreaNormal.ForeColor = Color.FromArgb(10, 113, 184);
            btnAreaVIP.BackColor = Color.FromArgb(10, 113, 184);
            btnAreaVIP.ForeColor = Color.White;
            addControlsPanel(uc_AreaNormal.Instance);
        }

        private void btnAreaVIP_Click(object sender, EventArgs e)
        {
            btnAreaVIP.BackColor = Color.White;
            btnAreaVIP.ForeColor = Color.FromArgb(10, 113, 184);
            btnAreaNormal.BackColor = Color.FromArgb(10, 113, 184);
            btnAreaNormal.ForeColor = Color.White;
            addControlsPanel(uc_AreaVIP.Instance);
        }

        private void addControlsPanel(Control control)
        {
            control.Dock = DockStyle.Fill;
            pnlControl.Controls.Clear();
            pnlControl.Controls.Add(control);
        }
    }
}
