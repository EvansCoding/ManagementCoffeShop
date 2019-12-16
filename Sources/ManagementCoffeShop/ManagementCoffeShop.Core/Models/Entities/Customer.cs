namespace ManagementCoffeShop.Core.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using Interfaces;
    using Utilities;

    public partial class Customer : IBaseEntity
    {
        public Customer()
        {
            Id = GuidComb.GenerateComb();
        }

        public Guid Id { get; set; }
        public string nameCustomer { get; set; }
        public string phoneNumber { get; set; }
        public bool status { get; set; }

        public virtual IList<BillSell>  BillSells { get; set; }
    }
}
