using ManagementCoffeShop.Core.Data.Context;
using ManagementCoffeShop.Core.Models.Entities;
using ManagementCoffeShop.Core.Services;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ManagementCoffeShop.UserController
{
    public partial class uc_Table : DevExpress.XtraEditors.XtraUserControl
    {

        public uc_Table(Employe _employe, Tables _table, int i)
        {
            InitializeComponent();
            table = _table;
            index = i;
            employe = _employe;
        }

        Tables table;
        int index;
        BillSell _billSell;
        Employe employe = null;

        private void uc_Table_Load(object sender, EventArgs e)
        {
            BillSellService billSellService = new BillSellService(new CoffeShopContext());
            label1.Text = index.ToString();
            if (table.status)
            {
                label1.BackColor = Color.Yellow;
                Name = billSellService.GetBillSell(table).Id.ToString();
                _billSell = billSellService.GetBillSell(table);
            }

        }

        private void uc_Table_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
            fORDER.checkStatus = true;
            fORDER.staticTable = table;
            fORDER f1 = Application.OpenForms.OfType<fORDER>().FirstOrDefault();

            if (f1 != null)
            {
                f1.showTableInMenu(table, index);
                if (_billSell != null)
                {
                    BillSellService billSellService = new BillSellService(new CoffeShopContext());
                    DetailBillSellService detailBillSellService = new DetailBillSellService(new CoffeShopContext());
                    var listDetail = detailBillSellService.GetDetailBillSell(_billSell);
                    f1.showListProductOrder(listDetail);
                }
                else f1.flpOrdered.Controls.Clear();
            }
            loadInfoOrder(_billSell);
        }
        bool checkOrderd = true;
        private void orderProduct_Click(object sender, EventArgs e)
        {
            fORDER.checkStatus = false;
            BillSellService billSellService = new BillSellService(new CoffeShopContext());
            if (!table.status)
            {
                _billSell = billSellService.CreateBillSell(employe, null, table);
                Name = _billSell.Id.ToString();
                label1.BackColor = Color.Yellow;
            }
            else
            {
                Guid Id = new Guid(Name);
                _billSell = billSellService.GetBillWithId(Id);
            }
            if(_billSell != null)
                reloadProducts();
            checkOrderd = true;
            fORDER.staticBill = _billSell;
            fORDER.staticTable = table;
        }

        private void reloadProducts()
        {
            loadInfoOrder(_billSell);
            DetailBillSellService detailBillSellService = new DetailBillSellService(new CoffeShopContext());
            var listDetail = detailBillSellService.GetDetailBillSell(_billSell);
            fORDER f1 = Application.OpenForms.OfType<fORDER>().FirstOrDefault();
            if (f1 != null)
            {
                if (checkOrderd)
                {
                    f1.orderProducts(_billSell);
                    f1.showListProductOrder(listDetail);
                }
                else
                {
                    f1.flpOrdered.Controls.Clear();
                    uc_AreaNormal.Instance.preLoad();
                    uc_AreaVIP.Instance.preLoad();
                }

            }
        }
        private void deleteTable_Click(object sender, EventArgs e)
        {
            checkOrderd = false;
            if(_billSell != null)
            {
                DetailBillSellService detailBillSellService = new DetailBillSellService(new CoffeShopContext());
                detailBillSellService.DeleteDetailBillSellAll(_billSell);
                BillSellService bs= new BillSellService(new CoffeShopContext());
                TableService tableService = new TableService(new CoffeShopContext());

                var tb = tableService.GetTables(_billSell);
                tableService.SetStatusTable(tb, false);
                bs.DeleteBillSell(_billSell);

                reloadProducts();
            }

        }

        private void loadInfoOrder(BillSell billSell)
        {
            fORDER f1 = Application.OpenForms.OfType<fORDER>().FirstOrDefault();
            if (f1 != null)
            {
                if(billSell == null)
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
    }
}
