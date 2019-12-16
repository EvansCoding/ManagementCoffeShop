namespace ManagementCoffeShop.Core.Models.Entities
{
    using ManagementCoffeShop.Core.Interfaces;
    using ManagementCoffeShop.Core.Utilities;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class DetailBillSell : IBaseEntity
    {
        public DetailBillSell()
        {
            Id = GuidComb.GenerateComb();
        }
        public Guid Id { get; set; }
        public int Quantum { get; set; }
        public decimal Total { get; set; }


        public virtual Product Product { get; set; }

        public virtual IList<BillSell> BillSells { get; set; }
    }
}
