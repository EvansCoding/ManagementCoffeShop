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
using ManagementCoffeShop.Core.Services;
using ManagementCoffeShop.Core.Data.Context;

namespace ManagementCoffeShop.UserController
{
    public partial class uc_MArea : DevExpress.XtraEditors.XtraUserControl
    {
        public uc_MArea()
        {
            InitializeComponent();
        }

        private void uc_MArea_Load(object sender, EventArgs e)
        {
            AreaService areaService = new AreaService(new CoffeShopContext());
            gridControl1.DataSource = areaService.GetAllArea();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            object dataTable = gridControl1.DataSource;
            AreaService areaService = new AreaService(new CoffeShopContext());
            areaService.updateArea(dataTable);
        }
    }
}
