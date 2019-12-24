namespace ManagementCoffeShop.Core.Services
{
    using ManagementCoffeShop.Core.Interfaces;
    using ManagementCoffeShop.Core.Models.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Entity;
    using System.Linq;

    public class TableService : ITableService
    {
        private ICoffeShopContext _context;
        public TableService(ICoffeShopContext context)
        {
            _context = context;
        }

        public Tables GetTable(string idTable)
        {
            try
            {
                return _context.Tables.Where(x => x.Id == new Guid(idTable)).SingleOrDefault();
            }
            catch (Exception)
            {
            }
            return null;
        }

        public List<Tables> GetTables(Area area)
        {
            var listTableNOR = _context.Tables.Where(x => x.Area.Id == area.Id).Include(t => t.BillSells).ToList();
            return listTableNOR;
        }

        public Tables GetTables(Tables tables)
        {
            return _context.Tables.Where(x => x.Id == tables.Id).Include(x => x.BillSells).Include(x => x.Area).SingleOrDefault();
        }

        public bool SetStatusTable(Tables tables, bool status)
        {
            try
            {
                var table = _context.Tables.FirstOrDefault(x => x.Id == tables.Id);
                table.status = status;
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
            }
            return false;
        }

        public DataTable GetAllTable()
        {
            var list = _context.Tables.Include(x => x.Area).Select(x => x).ToList();
            DataTable dataTable = new DataTable();
            dataTable.Clear();
            dataTable.Columns.Add("Id", typeof(string));
            dataTable.Columns.Add("nameTable", typeof(string));
            dataTable.Columns.Add("status", typeof(bool));
            dataTable.Columns.Add("Note", typeof(string));
            dataTable.Columns.Add("nameArea", typeof(string));
            DataRow row;
            foreach (var item in list)
            {
                row = dataTable.NewRow();
                row[0] = item.Id.ToString();
                row[1] = item.nameTable.ToString();
                row[2] = item.status;
                row[3] = item.Note;
                row[4] = item.Area.nameArea;

                dataTable.Rows.Add(row);
            }
            return dataTable;
        }
        public Tables GetTables(BillSell billSell)
        {
            return _context.Tables.Where(x => x.Id == billSell.Table.Id).Include(x => x.BillSells).SingleOrDefault();
        }

        public bool updateTables(object tables)
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable.Clear();
                dataTable.Columns.Add("Id", typeof(string));
                dataTable.Columns.Add("nameTable", typeof(string));
                dataTable.Columns.Add("status", typeof(bool));
                dataTable.Columns.Add("Note", typeof(string));
                dataTable.Columns.Add("nameArea", typeof(string));

                AreaService areaService = new AreaService(_context);
                dataTable = tables as DataTable;
                int i = 0;
                foreach (DataRow item in dataTable.Rows)
                {
                    Guid IdTable = new Guid(item.Table.Rows[i]["Id"].ToString());
                    string nameTable = item.Table.Rows[i]["nameTable"].ToString();
                    bool status = (bool)(item.Table.Rows[i]["status"]);
                    string Note = item.Table.Rows[i]["Note"].ToString();
                    string nameArea = item.Table.Rows[i]["nameArea"].ToString();

                    Area area = areaService.GetArea(nameArea);
                    if (area != null)
                    {
                        var table = _context.Tables.Where(x => x.Id == IdTable).Include(x => x.Area).SingleOrDefault();
                        table.nameTable = nameTable;
                        table.status = status;
                        table.Note = Note;
                        table.Area = area;
                        _context.SaveChanges();
                    }
                    i++;
                }
                return true;
            }
            catch (Exception)
            {
            }
            return false;
        }

        public bool Delete(string Id)
        {
            try
            {
                Guid _id = new Guid(Id);

                var table = _context.Tables.Where(x => x.Id == _id).Include(x => x.Area).SingleOrDefault();
                if (table == null) return false;
                _context.Tables.Remove(table);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
            }
            return false;
        }

        public bool Insert(string name, string nameArea)
        {
            try
            {
                AreaService areaService = new AreaService(_context);
                Area area = areaService.GetArea(nameArea);
                if (area == null)
                    return false;

                Tables tables = new Tables
                {
                    nameTable = name,
                    status = false,
                    Note = null
                };

                tables.Area = area;
                _context.Tables.Add(tables);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
            }
            return false;
        }
        /// <inheritdoc />
        public void RefreshContext(ICoffeShopContext context)
        {
            _context = context;
        }
    }
}
