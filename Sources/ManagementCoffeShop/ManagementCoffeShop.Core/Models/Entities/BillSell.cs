namespace ManagementCoffeShop.Core.Models.Entities
{
    using ManagementCoffeShop.Core.Interfaces;
    using ManagementCoffeShop.Core.Utilities;
    using System;
    using System.Collections.Generic;

    public partial class BillSell : IBaseEntity
    {
        public BillSell()
        {
            Id = GuidComb.GenerateComb();
        }

        public Guid Id { get; set; }
        public DateTime createDate { get; set; }
        public decimal totalMoney { get; set; }
        public bool status { get; set; }

       // public virtual Customer Customer { get; set; }
        public virtual Employe Employe { get; set; }
        public virtual Tables Table { get; set; }

        public virtual IList<DetailBillSell> DetailBillSells { get; set; }
    }
}
