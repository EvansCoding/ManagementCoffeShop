namespace ManagementCoffeShop.Core.Models.Entities
{
    using ManagementCoffeShop.Core.Interfaces;
    using ManagementCoffeShop.Core.Utilities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public partial class RawMaterial : IBaseEntity
    {
        public RawMaterial()
        {
            Id = GuidComb.GenerateComb();
        }

        public Guid Id { get; set; }
        public string nameRawMaterial { get; set; }
        public decimal priceRawMaterial { get; set; }
        public int InventoryNumber { get; set; }

        public virtual Unit Unit { get; set; }
        public virtual IList<Supplier> Suppliers { get; set; }
    }
}
