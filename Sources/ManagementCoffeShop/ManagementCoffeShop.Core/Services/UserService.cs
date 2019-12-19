namespace ManagementCoffeShop.Core.Services
{
    using Interfaces;
    using Models.Entities;
    using Models.Enum;
    using Utilities;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Data.Entity;
    using System.Collections.Generic;
    using System.Data;
    using System;

    public class UserService : IUserService
    {

        private ICoffeShopContext _context;
        public UserService(ICoffeShopContext context)
        {
            _context = context;
        }

        // Create Function Code Login
        public LoginAttemptStatus LastLoginStatus { get; private set; } = LoginAttemptStatus.LoginSuccessful;

        public bool ValidateUser(string userName, string password)
        {
            LastLoginStatus = LoginAttemptStatus.LoginSuccessful;
            var user = GetUser(userName);
            if (user == null)
            {
              LastLoginStatus = LoginAttemptStatus.UserNotFound;
                return false;
            }

            var hash = GenerateHash.Instance.ComputeSha256Hash(password);
            var passwordMatches = hash == user.password;
            
            if(!passwordMatches)
            {
                LastLoginStatus = LoginAttemptStatus.PasswordIncorrect;
                return false;
            }

            return LastLoginStatus == LoginAttemptStatus.LoginSuccessful;
        }

        
        public Employe GetUser(string userName)
        {
            var user = _context.Employes.FirstOrDefault(x => x.userName == userName);
            return user;
        }

        public Employe GetUser(Employe employe)
        {
            return _context.Employes.AsNoTracking().Where(x => x.Id == employe.Id).Include(x => x.Offices).SingleOrDefault();
        }
        /// <inheritdoc />
        public void RefreshContext(ICoffeShopContext context)
        {
            _context = context;
        }


        public DataTable GetAll()
        {
            var list =  _context.Employes.Include(x => x.Offices).Select(x => x).ToList();

            DataTable dataTable = new DataTable();
            dataTable.Clear();
            dataTable.Columns.Add("Id", typeof(string));
            dataTable.Columns.Add("userName", typeof(string));
            dataTable.Columns.Add("password", typeof(string));
            dataTable.Columns.Add("fullName", typeof(string));
            dataTable.Columns.Add("sex", typeof(bool));
            dataTable.Columns.Add("birthDay", typeof(string));
            dataTable.Columns.Add("address", typeof(string));
            dataTable.Columns.Add("phoneNumber", typeof(string));
            dataTable.Columns.Add("email", typeof(string));
            dataTable.Columns.Add("dayAtWork", typeof(string));
            dataTable.Columns.Add("statusOfWork", typeof(bool));
            dataTable.Columns.Add("nameOffice", typeof(string));
            DataRow row;
            foreach (var item in list)
            {
                row = dataTable.NewRow();
                row[0] = item.Id.ToString();
                row[1] = item.userName;
                row[2] = item.password;
                row[3] = item.fullName;
                row[4] = item.sex;
                row[5] = item.birthDay;
                row[6] = item.address;
                row[7] = item.phoneNumber;
                row[8] = item.email;
                row[9] = item.dayAtWork;
                row[10] = item.statusOfWork;
                row[11] = item.Offices.nameOffice;
                dataTable.Rows.Add(row);
            }
            return dataTable;
        }

        public bool Update(object tables)
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable.Clear();
                dataTable.Columns.Add("Id", typeof(string));
                dataTable.Columns.Add("userName", typeof(string));
                dataTable.Columns.Add("password", typeof(string));
                dataTable.Columns.Add("fullName", typeof(string));
                dataTable.Columns.Add("sex", typeof(bool));
                dataTable.Columns.Add("birthDay", typeof(string));
                dataTable.Columns.Add("address", typeof(string));
                dataTable.Columns.Add("phoneNumber", typeof(string));
                dataTable.Columns.Add("email", typeof(string));
                dataTable.Columns.Add("dayAtWork", typeof(string));
                dataTable.Columns.Add("statusOfWork", typeof(bool));
                dataTable.Columns.Add("nameOffice", typeof(string));

                OfficeService officeService = new OfficeService(_context);

                dataTable = tables as DataTable;
                int i = 0;
                foreach (DataRow item in dataTable.Rows)
                {
                    Guid Id = new Guid(item.Table.Rows[i]["Id"].ToString());
                    string username = item.Table.Rows[i]["userName"].ToString();
                    string password = item.Table.Rows[i]["password"].ToString();
                    string fullName = item.Table.Rows[i]["fullName"].ToString();
                    bool sex = (bool)item.Table.Rows[i]["sex"];
                    DateTime birthDay = Convert.ToDateTime(item.Table.Rows[i]["birthDay"].ToString());
                    string address = item.Table.Rows[i]["address"].ToString();
                    string phoneNumber = item.Table.Rows[i]["phoneNumber"].ToString();
                    string email = item.Table.Rows[i]["email"].ToString();
                    DateTime dayAtWork = Convert.ToDateTime(item.Table.Rows[i]["dayAtWork"].ToString());
                    bool statusOfWork = (bool)(item.Table.Rows[i]["statusOfWork"]);
                    string nameOffice = item.Table.Rows[i]["nameOffice"].ToString();

                    Office off = officeService.GetOffice(nameOffice);
                    if (off != null)
                    {
                        var user = _context.Employes.Where(x => x.Id == Id).Include(x => x.Offices).SingleOrDefault();
                        user.userName = username;
                        if (user.password != password)
                            user.password = GenerateHash.Instance.ComputeSha256Hash(password);
                        user.fullName = fullName;
                        user.sex = sex;
                        user.birthDay = birthDay;
                        user.address = address;
                        user.phoneNumber = phoneNumber;
                        user.email = email;
                        user.dayAtWork = dayAtWork;
                        user.statusOfWork = statusOfWork;
                        user.Offices = off;
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

                var user = _context.Employes.Where(x => x.Id == _id).Include(x => x.Offices).SingleOrDefault();
                if (user == null) return false;
                _context.Employes.Remove(user);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
            }
            return false;
        }

        public bool Insert(string userName, string password, string fullName, string sex, string birthDay, string  address, string phone, string email, string nameOff)
        {
            try
            {
                OfficeService officeService = new OfficeService(_context);
                Office off = officeService.GetOffice(nameOff);
                if (off == null)
                    return false;
                var userEx = _context.Employes.Where(x => x.userName == userName).SingleOrDefault();

                if (userEx != null) return false;

                Employe user = new Employe
                {
                    userName = userName,
                    password = GenerateHash.Instance.ComputeSha256Hash(password),
                    fullName = fullName,
                    sex = sex == "nam" ? true : false,
                    birthDay = Convert.ToDateTime( birthDay),
                    address = address,
                    phoneNumber = phone,
                    email = email,
                    dayAtWork = DateTime.Now,
                    statusOfWork = true,
                    createDate = DateTime.Now,
                    updateDate = DateTime.Now,
                    Offices = off
                };

                _context.Employes.Add(user);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
            }
            return false;
        }
    }
}
