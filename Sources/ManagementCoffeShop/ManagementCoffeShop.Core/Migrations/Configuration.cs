namespace ManagementCoffeShop.Core.Migrations
{
    using ManagementCoffeShop.Core.Models.Entities;
    using ManagementCoffeShop.Core.Utilities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ManagementCoffeShop.Core.Data.Context.CoffeShopContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ManagementCoffeShop.Core.Data.Context.CoffeShopContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            var employeesOffice = context.Offices.FirstOrDefault(x => x.nameOffice == Constants.Constants.Employees);
            if (employeesOffice == null)
            {
                employeesOffice = new Models.Entities.Office { nameOffice = Constants.Constants.Employees, createdDay = DateTime.Now, updatedDay = DateTime.Now };
                context.Offices.Add(employeesOffice);
                context.SaveChanges();
            }

            var managerOffice = context.Offices.FirstOrDefault(x => x.nameOffice == Constants.Constants.Manager);
            if (managerOffice == null)
            {
                managerOffice = new Models.Entities.Office { nameOffice = Constants.Constants.Manager, createdDay = DateTime.Now, updatedDay = DateTime.Now };
                context.Offices.Add(managerOffice);
                context.SaveChanges();
            }

            // If the admin user exists then don't do anything else
            const string password = "evans";
            if (context.Employes.FirstOrDefault(x => x.userName == Constants.Constants.administrator) == null)
            {
                var admin = new Employe
                {
                    userName = Constants.Constants.administrator,
                    password = GenerateHash.Instance.ComputeSha256Hash(password),
                    fullName = "EVANS CODING",
                    sex = true,
                    birthDay = new DateTime(1999, 08, 22),
                    address = "CaoLanh City",
                    phoneNumber = "0836980284",
                    email = "nguyen.ntkiet1999@gmail.com",
                    dayAtWork = DateTime.Now,
                    statusOfWork = true,
                    createDate = DateTime.Now,
                    updateDate = DateTime.Now
                };
                var theManager = context.Offices.FirstOrDefault(x => x.nameOffice == Constants.Constants.Manager);
                if (theManager != null)
                {
                    admin.Offices = theManager;
                }

                context.Employes.Add(admin);
                context.SaveChanges();
            }
        }
    }
}
