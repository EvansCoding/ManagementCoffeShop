using ManagementCoffeShop.Classes;
using ManagementCoffeShop.Core.Models.Entities;
using ManagementCoffeShop.UserController;
using System;
using System.Windows.Forms;

namespace ManagementCoffeShop
{
    public partial class fMain : DevExpress.XtraEditors.XtraForm
    {
        private static fMain instance;

        public static fMain Instance
        {
            get
            {
                if (instance == null) return instance = new fMain(employe);
                return instance;
            }
        }
        public static Employe employe;
        public fMain(Employe empl)
        {
            InitializeComponent();
            employe = empl;
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            loadUControls();
            uc_MSell uc_MSell = new uc_MSell();
            myControls.Instance.addCotrolTableToOrder(uc_MSell, panel1);
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
            uc_EOffice uc_EOffice = new uc_EOffice();
            flpTop.Controls.Add(uc_EOffice);
        }

        public void SellControlAdd(int i)
        {
            if (i == 1)
            {
                uc_MSell uc_MSell = new uc_MSell();
                myControls.Instance.addCotrolTableToOrder(uc_MSell, panel1);
            }
            if (i == 2)
            {
                uc_MArea uc_MArea = new uc_MArea();
                myControls.Instance.addCotrolTableToOrder(uc_MArea, panel1);
            }
            if (i == 3)
            {
                uc_MTables uc_MTables = new uc_MTables();
                myControls.Instance.addCotrolTableToOrder(uc_MTables, panel1);
            }
            if (i == 4)
            {
                uc_MSupplier uc_MSupplier = new uc_MSupplier();
                myControls.Instance.addCotrolTableToOrder(uc_MSupplier, panel1);
            }

            if (i == 5)
            {
                uc_MEmploye uc_MEmploye = new uc_MEmploye();
                myControls.Instance.addCotrolTableToOrder(uc_MEmploye, panel1);
            }

            if (i == 6)
            {
                uc_MOffice uc_MOffice = new uc_MOffice();
                myControls.Instance.addCotrolTableToOrder(uc_MOffice, panel1);
            }

            if (i == 7)
            {
                uc_MProduct uc_MProduct = new uc_MProduct();
                myControls.Instance.addCotrolTableToOrder(uc_MProduct, panel1);
            }
        }

        private void fMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Restart();
        }

        bool check = true;
        private void fMain_KeyUp(object sender, KeyEventArgs e)
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
    }
}