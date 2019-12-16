namespace ManagementCoffeShop.Core.Models.Entities
{
    using ManagementCoffeShop.Core.Interfaces;
    using ManagementCoffeShop.Core.Utilities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public partial class Supplier : IBaseEntity
    {
        public Supplier()
        {
            Id = GuidComb.GenerateComb();
        }

        public Guid Id { get; set; }
        public string nameSupplier { get; set; }
        public string address { get; set; } 
        public string phoneNumber { get; set; }


        public virtual IList<RawMaterial> RawMaterials { get; set; }
    }
}
