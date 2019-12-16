namespace ManagementCoffeShop.Core.Interfaces
{
    using ManagementCoffeShop.Core.Models.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface ITableService : IContextService
    {
        List<Tables> GetTables(Area area);
       // Tables GetTables(Guid Id);
        Tables GetTables(Tables tables);
        bool SetStatusTable(Tables tables, bool status);
    }
}
