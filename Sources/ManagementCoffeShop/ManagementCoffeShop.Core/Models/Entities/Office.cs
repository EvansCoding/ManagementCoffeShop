namespace ManagementCoffeShop.Core.Models.Entities
{
    using Interfaces;
    using Utilities;
    using System;
    using System.Collections.Generic;

    public partial class Office : IBaseEntity
    {
        public Office()
        {
            Id = GuidComb.GenerateComb();
        }
        public Guid Id { get; set; }
        public string nameOffice { get; set; }
        public DateTime createdDay { get; set; }
        public DateTime updatedDay { get; set; }

        public virtual IList<Employe> User { get; set; }
    }
}
