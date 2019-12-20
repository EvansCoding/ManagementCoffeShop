using ManagementCoffeShop.Core.Interfaces;
using ManagementCoffeShop.Core.Models.Entities;
using ManagementCoffeShop.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ManagementCoffeShop.Core.Services
{
    public class ProductService : IProductService
    {
        private ICoffeShopContext _context;
        public ProductService(ICoffeShopContext context)
        {
            _context = context;
        }

        public List<Product> GetAllProducts()
        {
            var listProducts = _context.Products.Select(c => c).ToList();
            return listProducts;
        }

        public List<Product> GetProcductsToType(ProductType productType)
        {
            var listProducts = _context.Products.Where(c => c.ProductType.Id == productType.Id).ToList();
            return listProducts;
        }

        /// <inheritdoc />
        public void RefreshContext(ICoffeShopContext context)
        {
            _context = context;
        }

        public Product GetProduct(Product product)
        {
            return _context.Products.Where(x => x.Id == product.Id).Include(x => x.ProductType).SingleOrDefault();
        }

        public DataTable GetAllProduct()
        {
            var list = _context.Products.Include(x => x.Unit).Include(x => x.ProductType).Select(x => x).ToList();
            DataTable dataTable = new DataTable();
            dataTable.Clear();
            dataTable.Columns.Add("Id", typeof(string));
            dataTable.Columns.Add("nameProduct", typeof(string));
            dataTable.Columns.Add("pathImage", typeof(Image));
            dataTable.Columns.Add("priceProduct", typeof(decimal));
            dataTable.Columns.Add("nameProductType", typeof(string));
            dataTable.Columns.Add("nameUnit", typeof(string));
            DataRow row;
            foreach (var item in list)
            {
                row = dataTable.NewRow();
                row[0] = item.Id.ToString();
                row[1] = item.nameProduct;
                try
                {
                    row[2] = Image.FromFile(Application.StartupPath + "\\Images\\" + item.pathImage + ".png");
                }
                catch (System.Exception)
                {
                    row[2] = Image.FromFile(Application.StartupPath + "\\Images\\" + item.pathImage + ".jpg");
                }
                
                row[3] = item.priceProduct;
                row[4] = item.ProductType.nameProductType;
                row[5] = item.Unit.nameUnit;
                dataTable.Rows.Add(row);
            }
            return dataTable;
        }

        public bool Delete(string Id)
        {
            try
            {
                Guid _id = new Guid(Id);

                var product = _context.Products.Where(x => x.Id == _id).Include(x => x.Unit).Include(x => x.ProductType).SingleOrDefault();
                if (product == null) return false;
                _context.Products.Remove(product);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
            }
            return false;
        }

        public bool updateProduct(object tables)
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable.Clear();
                dataTable.Columns.Add("Id", typeof(string));
                dataTable.Columns.Add("nameProduct", typeof(string));
                dataTable.Columns.Add("pathImage", typeof(Image));
                dataTable.Columns.Add("priceProduct", typeof(decimal));
                dataTable.Columns.Add("nameProductType", typeof(string));
                dataTable.Columns.Add("nameUnit", typeof(string));

                UnitService unitService = new UnitService(_context);
                ProductTypeService productTypeService = new ProductTypeService(_context);
                dataTable = tables as DataTable;
                int i = 0;
                foreach (DataRow item in dataTable.Rows)
                {
                    Guid Id = new Guid(item.Table.Rows[i]["Id"].ToString());
                    string nameProduct = item.Table.Rows[i]["nameProduct"].ToString();
                    string price = item.Table.Rows[i]["priceProduct"].ToString();
                    string productTypeName = item.Table.Rows[i]["nameProductType"].ToString();
                    string unitname = item.Table.Rows[i]["nameUnit"].ToString();

                    Unit unit = unitService.GetName(unitname);
                    ProductType productType = productTypeService.GetName(productTypeName);
                    if (unit != null && productType != null)
                    {
                        var product = _context.Products.Where(x => x.Id == Id).Include(x => x.Unit).Include(x => x.ProductType).SingleOrDefault();
                        product.nameProduct = nameProduct;
                        product.priceProduct = Convert.ToDecimal(price);
                        product.ProductType = productType;
                        product.Unit = unit;
                        _context.SaveChanges();
                    }
                    i++;
                }
                return true;
            }
            catch (Exception)
            {
            }
            return false;
        }

        public bool Insert(string nameProduct, string price, string pathImage, string nameUnit, string nameProductType)
        {
            try
            {
                UnitService unitService = new UnitService(_context);
                ProductTypeService productTypeService = new ProductTypeService(_context);

                var unit = unitService.GetName(nameUnit);
                var productType = productTypeService.GetName(nameProductType);
                if (productType == null || unit == null)
                    return false;
                var userEx = _context.Products.Where(x => x.nameProduct == nameProduct).SingleOrDefault();

                if (userEx != null) return false;
                string path = saveImage.Instance.saveImagePath(pathImage);
                if (path.Equals("")) return false;
                Product product = new Product
                {
                    nameProduct = nameProduct,

                    pathImage = path,
                    priceProduct = Convert.ToDecimal(price),
                    Unit = unit,
                    ProductType = productType
                };

                _context.Products.Add(product);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
            }
            return false;
        }

        public Product GetProductWithID(Guid ID)
        {
            return _context.Products.Where(x => x.Id == ID).Include(x => x.Unit).Include(x => x.ProductType).SingleOrDefault();
        }

    }
}
