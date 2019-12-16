using ManagementCoffeShop.Core.Data.Context;
using ManagementCoffeShop.Core.Models.Entities;
using ManagementCoffeShop.Core.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ManagementCoffeShop.UserController
{
    public partial class uc_PanelOrderProducts : DevExpress.XtraEditors.XtraUserControl
    {
        private static uc_PanelOrderProducts instance;
        public static uc_PanelOrderProducts Instance
        {
            get
            {
                if (instance == null) return instance = new uc_PanelOrderProducts();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        BillSell _BillSell;
        public BillSell BillSell { get => _BillSell; set => _BillSell = value; }

        public uc_PanelOrderProducts()
        {
            InitializeComponent();
        }


        private void uc_PanelOrderProducts_Load(object sender, EventArgs e)
        {
            reLoad();
        }


        public void reLoad()
        {
            loadAllProductType(BillSell);
            loadAllProducts();
        }

        private void showItemProductType(ProductType productType)
        {
            uc_KindProduct uc_KindProduct = new uc_KindProduct(productType);
            flpKindProducts.BeginInvoke((Action)(() =>
            {
                flpKindProducts.Controls.Add(uc_KindProduct);
            }));
        }

        private void loadAllProductType(BillSell billSell)
        {
            BillSell = billSell;
            flpKindProducts.Controls.Clear();
            ProductTypeService productTypeService = new ProductTypeService(new CoffeShopContext());
            var listProductType = productTypeService.GetProductTypes();
            foreach (var item in listProductType)
            {
                showItemProductType(item);
            }
        }

        private void checkExistBillDetail(BillSell billSell)
        {
            BillSellService bs = new BillSellService(new CoffeShopContext());
            DetailBillSellService detailBillSellService = new DetailBillSellService(new CoffeShopContext());
            var listDetail = detailBillSellService.GetDetailBillSell(billSell);
            var a = uc_PanelTables.Instance.Controls.Find(billSell.Id.ToString(), true);
            string b= null;
            foreach (uc_Table item in a)
            {
                b = item.Name;
            }
            Console.WriteLine(b);

            if (listDetail.Count == 0)
            {
                ManagementCoffeShop.Core.Models.Entities.BillSell billSells = new ManagementCoffeShop.Core.Models.Entities.BillSell();
                billSells = bs.GetBillWithId(new Guid(b));
                TableService tableService = new TableService(new CoffeShopContext());
                Tables tb = tableService.GetTables(billSells);
                tableService.SetStatusTable(tb, false);
                bs.DeleteBillSell(billSell);
            }

        }
        private void showItemProduct(Product product)
        {
            uc_Product uc_Product = new uc_Product(product);
            flpProducts.BeginInvoke((Action)(() =>
            {
                flpProducts.Controls.Add(uc_Product);
            }));
        }

        public void loadAllProducts()
        {
            flpProducts.Controls.Clear();
            ProductService productService = new ProductService(new CoffeShopContext());

            var listProducts = productService.GetAllProducts();

            foreach (var item in listProducts)
            {
                showItemProduct(item);
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            checkExistBillDetail(BillSell);
            fORDER.checkStatus = true;
           
            fORDER f1 = Application.OpenForms.OfType<fORDER>().FirstOrDefault();
            if (f1 != null)
            {
                f1.returnUC_PanelTables();
                f1.flpOrdered.Controls.Clear();
            }
        }

        private void lbLoaiSanPham_Click(object sender, EventArgs e)
        {
            reLoad();
        }

        public void ShowProductToType(ProductType productType)
        {
            flpProducts.Controls.Clear();
            ProductService productService = new ProductService(new CoffeShopContext());
            var listProducts = productService.GetProcductsToType(productType);
            foreach (var item in listProducts)
            {
                showItemProduct(item);
            }
        }
    }
}
