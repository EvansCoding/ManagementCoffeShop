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
using ManagementCoffeShop.Core.Models.Entities;
using ManagementCoffeShop.Core.Constants;
using ManagementCoffeShop.Core.Services;
using ManagementCoffeShop.Core.Data.Context;

namespace ManagementCoffeShop
{
    public partial class fORDER : DevExpress.XtraEditors.XtraForm
    {
        private static fORDER instance;
        public static fORDER Instance
        {
            get
            {
                if (instance == null) return instance = new fORDER(_employe);
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        #region INITIALIZE
        public fORDER(Employe employe)
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            _employe = employe;
        }
        #endregion

        static Employe _employe;
        BillSell _billSell;
        #region METHODS
        public Employe GetEmploye()
        {
            return _employe;
        } 
        public void orderProducts(BillSell billSell)
        {
            _billSell = billSell;
            uc_PanelOrderProducts.Instance.BillSell = billSell;
            myControls.Instance.addCotrolTableToOrder(uc_PanelOrderProducts.Instance, pnlControl);
        }

        public void returnUC_PanelTables()
        {
            myControls.Instance.addCotrolTableToOrder(uc_PanelTables.Instance, pnlControl);
            //var h = Handle;
            uc_AreaNormal.Instance.preLoad();
            uc_AreaVIP.Instance.preLoad();
        }
        #endregion

        #region EVENTS

        private void fORDER_Load(object sender, EventArgs e)
        {
            myControls.Instance.addCotrolTableToOrder(uc_PanelTables.Instance, pnlControl);
            lbNameEmploye.Text = _employe.fullName;
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
        public static bool checkStatus = true;
        public static BillSell staticBill;
        public static Tables staticTable;
        public void showTableInMenu(Tables table, int i)
        {
            if(table.Area.nameArea.Equals(Constants.areaNormal) )
            {
                lbNamTable.Text = table.nameTable.ToUpper() + " - THƯỜNG";
                btnNumberTable.Text = "#" + i.ToString();
            }
            if (table.Area.nameArea.Equals(Constants.areaVIP) )
            {
                lbNamTable.Text = table.nameTable.ToUpper() + " - VIP";
                btnNumberTable.Text = "#" + i.ToString();
            }
        }

        public void addProductToListOrder(DetailBillSell DetailBillSell)
        {
            uc_Dish uc_Dish = new uc_Dish(DetailBillSell);
            flpOrdered.Controls.Add(uc_Dish);
        }

        public void showListProductOrder(List<DetailBillSell> detailBillSells)
        {
            flpOrdered.Controls.Clear();
            foreach (var item in detailBillSells)
            {
                uc_Dish uc_Dish = new uc_Dish(item);
                flpOrdered.Controls.Add(uc_Dish);
            }
        }
        public BillSell getBillSellofTable()
        {
            return _billSell;
        }

        public void refreshFLPOrdered(DetailBillSell billSell)
        {
            flpOrdered.Controls.RemoveByKey(billSell.Id.ToString());
            flpOrdered.Refresh();
            //DetailBillSellService detailBillSellService = new DetailBillSellService(new CoffeShopContext());

            //foreach (var item in detailBillSellService.GetDetailBillSell(billSell))
            //{
            //    uc_Dish uc_Dish = new uc_Dish(item);
            //    flpOrdered.Controls.Add(uc_Dish);
            //}
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        public void loadInfoOrder(BillSell billSell)
        {
            fORDER f1 = Application.OpenForms.OfType<fORDER>().FirstOrDefault();
            if (f1 != null)
            {
                if (billSell == null)
                {
                    f1.lbCount.Text = 0.ToString();
                    f1.lbTotal.Text = String.Format("{0:0,00} VNĐ", 0.0);
                    return;
                }
                DetailBillSellService detailBillSellService = new DetailBillSellService(new CoffeShopContext());
                f1.lbCount.Text = detailBillSellService.GetCountDetail(billSell).ToString();
                BillSellService bsService = new BillSellService(new CoffeShopContext());
                var detail = detailBillSellService.GetDetailBillSell(billSell);
                if (detail.Count == 0)
                {
                    f1.lbCount.Text = detailBillSellService.GetCountDetail(billSell).ToString();
                    f1.lbTotal.Text = String.Format("{0:0,00} VNĐ", 0.0);
                    return;
                }

                bsService.SetTotal(detail, billSell);
                f1.lbTotal.Text = String.Format("{0:0,00} VNĐ", bsService.GetTotal(billSell));

            }

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            BillSellService billSellService = new BillSellService(new CoffeShopContext());
            billSellService.setStatus(true, staticBill);
            TableService tableService = new TableService(new CoffeShopContext());
            tableService.SetStatusTable(staticTable,false );
            returnUC_PanelTables();
            flpOrdered.Controls.Clear();
        }
    }
}