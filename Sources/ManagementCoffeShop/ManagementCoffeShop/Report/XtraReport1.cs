using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace ManagementCoffeShop.Report
{
    public partial class lbTotalAll : DevExpress.XtraReports.UI.XtraReport
    {
        public lbTotalAll()
        {
            InitializeComponent();
        }

        public void load(DataTable data, string nameEmploye, decimal total)
        {
            lbNameEmploye.Text = nameEmploye;
            lbCreateDate.Text = DateTime.Now.ToString();
            DataSource = data;
            lbToTal.Text = total.ToString("N0");
            lbTTAll.Text = total.ToString("N0");
        }
    }
}
