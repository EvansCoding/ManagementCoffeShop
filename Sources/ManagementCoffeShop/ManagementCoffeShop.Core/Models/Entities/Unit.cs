namespace ManagementCoffeShop.Core.Models.Entities
{
    using ManagementCoffeShop.Core.Interfaces;
    using ManagementCoffeShop.Core.Utilities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public partial class Unit : IBaseEntity
    {
        public Unit()
        {
            Id = GuidComb.GenerateComb();
        }
        
        public Guid Id { get; set; }
        public string nameUnit { get; set; }

        public virtual IList<Product> Products { get; set; } 
        public virtual IList<RawMaterial> RawMaterials { get; set; }
    }
}
