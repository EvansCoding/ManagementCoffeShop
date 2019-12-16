using ManagementCoffeShop.Core.Constants;
using ManagementCoffeShop.Core.Data.Context;
using ManagementCoffeShop.Core.Models.Entities;
using ManagementCoffeShop.Core.Services;
using System;

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
            TableService tableService = new TableService(new CoffeShopContext());
            AreaService areaService = new AreaService(new CoffeShopContext());
            var area = areaService.GetArea(Constants.areaVIP);

            while (flpAreaVIP.Controls.Count > 0) flpAreaVIP.Controls.RemoveAt(0);

            int i = 0;
            foreach (var item in tableService.GetTables(area))
            {
                item.Area = area;
                showClient(item, ++i);
            }
        }

        public void showClient(Tables table, int i)
        {
            var employe = fORDER.Instance.GetEmploye();
            uc_Table uS_ShortInfo = new uc_Table(employe, table, i);
            //flpAreaVIP.BeginInvoke((Action)(() =>
        //    {
                flpAreaVIP.Controls.Add(uS_ShortInfo);
          //  }));
        }

        private void uc_AreaVIP_Load(object sender, EventArgs e)
        {
            preLoad();
        }
    }
}
