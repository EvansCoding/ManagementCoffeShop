namespace ManagementCoffeShop.Core.Models.Entities
{
    using Interfaces;
    using Utilities;
    using System;
    using System.Collections.Generic;

    public class Tables : IBaseEntity
    {
        public Tables()
        {
            Id = GuidComb.GenerateComb();
        }

        public Guid Id { get; set; }
        public string nameTable { get; set; }
        public bool status { get; set; }
        public string Note { get; set; }

        public virtual Area Area { get; set; }
        public virtual IList<BillSell> BillSells { get; set; }
        
    }
}
