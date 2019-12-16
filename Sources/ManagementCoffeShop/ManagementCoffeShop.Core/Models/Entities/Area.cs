namespace ManagementCoffeShop.Core.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using Interfaces;
    using Utilities;

    public partial class Area : IBaseEntity
    {
        public Area()
        {
            Id = GuidComb.GenerateComb();
        }

        public Guid Id { get; set; }
        public string nameArea { get; set; }
        public string Note { get; set; }

        public virtual IList<Tables> Tables { get; set; }
    }
}
