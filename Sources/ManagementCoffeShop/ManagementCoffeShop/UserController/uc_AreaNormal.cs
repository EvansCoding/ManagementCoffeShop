using ManagementCoffeShop.Core.Constants;
using ManagementCoffeShop.Core.Data.Context;
using ManagementCoffeShop.Core.Models.Entities;
using ManagementCoffeShop.Core.Services;
using System;

namespace ManagementCoffeShop.UserController
{
    public partial class uc_AreaNormal : DevExpress.XtraEditors.XtraUserControl
    {

        private static uc_AreaNormal instance;

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

        private uc_AreaNormal()
        {
            InitializeComponent();
        }

        public void preLoad()
        {
            TableService tableService = new TableService(new CoffeShopContext());
            AreaService areaService = new AreaService(new CoffeShopContext());
            var area = areaService.GetArea(Constants.areaNormal);

            while (flpAreaNormal.Controls.Count > 0) flpAreaNormal.Controls.RemoveAt(0);

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
          //  flpAreaNormal.BeginInvoke((Action)(() =>
         //   {
                flpAreaNormal.Controls.Add(uS_ShortInfo);
          //  }));
        }

        private void uc_AreaNormal_Load(object sender, EventArgs e)
        {
            preLoad();
        }
    }
}
