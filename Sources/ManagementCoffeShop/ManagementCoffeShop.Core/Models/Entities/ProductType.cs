namespace ManagementCoffeShop.Core.Models.Entities
{
    using ManagementCoffeShop.Core.Interfaces;
    using ManagementCoffeShop.Core.Utilities;
    using System;
    using System.Collections.Generic;

    public partial class ProductType : IBaseEntity
    {
        public ProductType()
        {
            Id = GuidComb.GenerateComb();
        }
        
        public Guid Id { get; set; }    
        public string nameProductType { get; set; }

        public virtual IList<Product> Products { get; set; }
    }
}
