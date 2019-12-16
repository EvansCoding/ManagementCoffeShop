namespace ManagementCoffeShop.Core.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Interfaces;
    using Utilities;

    public partial class Employe : IBaseEntity
    {
        public Employe()
        {
            Id = GuidComb.GenerateComb();
        }

        public Guid Id { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string fullName { get; set; }
        public bool sex { get; set; }
        public DateTime birthDay { get; set; }
        public string address { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public DateTime dayAtWork { get; set; }
        public bool statusOfWork { get; set; }
        public DateTime createDate { get; set; }
        public DateTime updateDate { get; set; }

        public virtual Office Offices { get; set; }
        public virtual IList<BillSell> BillSells { get; set; }
    }
}
