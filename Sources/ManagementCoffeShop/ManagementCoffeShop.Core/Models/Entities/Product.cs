namespace ManagementCoffeShop.Core.Models.Entities
{
    using ManagementCoffeShop.Core.Interfaces;
    using ManagementCoffeShop.Core.Utilities;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public partial class Product : IBaseEntity
    {
        public Product()
        {
            Id = GuidComb.GenerateComb();
        }

        public Guid Id { get; set; }
        public string nameProduct { get; set; }
        public string pathImage { get; set; }
        public decimal priceProduct { get; set; }

        public virtual ProductType ProductType { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual IList<DetailBillSell> DetailBillSells { get; set; }
    }
}
