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
using ManagementCoffeShop.Classes;

namespace ManagementCoffeShop
{
    public partial class fMain : DevExpress.XtraEditors.XtraForm
    {
        private static fMain instance;

        public static fMain Instance
        {
            get
            {
                if (instance == null) return instance = new fMain();
                return instance;
            }
        }

        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            loadUControls();
        }

        void loadUControls()
        {
            uc_ESELL uc_ESELL = new uc_ESELL();
            flpTop.Controls.Add(uc_ESELL);

            uc_EEmploye uc_EEmploye = new uc_EEmploye();
            flpTop.Controls.Add(uc_EEmploye);
            uc_EProduct uc_EProduct = new uc_EProduct();
            flpTop.Controls.Add(uc_EProduct);
            uc_ESupplier uc_ESupplier = new uc_ESupplier();
            flpTop.Controls.Add(uc_ESupplier);
            uc_EArea uc_EArea = new uc_EArea();
            flpTop.Controls.Add(uc_EArea);
            uc_ETable uc_Table = new uc_ETable();
            flpTop.Controls.Add(uc_Table);

        }

        public void SellControlAdd(int i)
        {
            if(i == 1)
            {
                uc_MSell uc_MSell = new uc_MSell();
                myControls.Instance.addCotrolTableToOrder(uc_MSell, panel1);
            }
            if(i == 2)
            {
                uc_MArea uc_MArea = new uc_MArea();
                myControls.Instance.addCotrolTableToOrder(uc_MArea, panel1);
            }
        }
    }
}