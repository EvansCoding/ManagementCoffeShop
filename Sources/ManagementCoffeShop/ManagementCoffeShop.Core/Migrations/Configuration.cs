﻿namespace ManagementCoffeShop.Core.Migrations
{
    using ManagementCoffeShop.Core.Models.Entities;
    using ManagementCoffeShop.Core.Utilities;
    using System;
    using System.Collections.Generic;
    using System.Configuration;
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
            if (!bool.Parse(ConfigurationManager.AppSettings["Database.Seed"] ?? bool.TrueString)) return;

            var employeesOffice = context.Offices.FirstOrDefault(x => x.nameOffice == Constants.Constants.Employees);
            if (employeesOffice == null)
            {
                employeesOffice = new Office { nameOffice = Constants.Constants.Employees, createdDay = DateTime.Now, updatedDay = DateTime.Now };
                context.Offices.Add(employeesOffice);
                context.SaveChanges();
            }

            var managerOffice = context.Offices.FirstOrDefault(x => x.nameOffice == Constants.Constants.Manager);
            if (managerOffice == null)
            {
                managerOffice = new Office { nameOffice = Constants.Constants.Manager, createdDay = DateTime.Now, updatedDay = DateTime.Now };
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
                    context.Employes.Add(admin);
                    context.SaveChanges();
                }

                // Insert info for Talbe Unit
                var aGlass = context.Units.FirstOrDefault(x => x.nameUnit == Constants.Constants.glass);
                if (aGlass == null)
                {
                    aGlass = new Unit
                    {
                        nameUnit = Constants.Constants.glass
                    };
                    context.Units.Add(aGlass);
                }

                var aCan = context.Units.FirstOrDefault(x => x.nameUnit == Constants.Constants.aCan);
                if (aCan == null)
                {
                    aCan = new Unit
                    {
                        nameUnit = Constants.Constants.aCan
                    };
                    context.Units.Add(aCan);
                    context.SaveChanges();
                }

                var container = context.Units.FirstOrDefault(x => x.nameUnit == Constants.Constants.container);
                if (container == null)
                {
                    container = new Unit
                    {
                        nameUnit = Constants.Constants.container
                    };
                    context.Units.Add(container);
                    context.SaveChanges();
                }

                var kilogram = context.Units.FirstOrDefault(x => x.nameUnit == Constants.Constants.kilogram);
                if (kilogram == null)
                {
                    kilogram = new Unit
                    {
                        nameUnit = Constants.Constants.kilogram
                    };
                    context.Units.Add(kilogram);
                    context.SaveChanges();
                }
                // insert Infor for Table Customer
                var customerDefault = context.Customers.FirstOrDefault(x => x.nameCustomer == Constants.Constants.customerDefault);
                if (customerDefault == null)
                {
                    customerDefault = new Customer
                    {
                        nameCustomer = Constants.Constants.customerDefault,
                        phoneNumber = Constants.Constants.phoneNumberCustomerDfault,
                        status = Constants.Constants.status
                    };
                    context.Customers.Add(customerDefault); ;
                    context.SaveChanges();
                }
                // Insert Info For Table Supplier
                var vinMart = context.Suppliers.FirstOrDefault(x => x.nameSupplier == Constants.Constants.vinMART);
                if (vinMart == null)
                {
                    vinMart = new Supplier
                    {
                        nameSupplier = Constants.Constants.vinMART,
                        address = "307, Cao Thắng, Cao Lãnh, Đồng Tháp",
                        phoneNumber = "9999999999"
                    };
                    context.Suppliers.Add(vinMart);
                    context.SaveChanges();
                }

                var coopMart = context.Suppliers.FirstOrDefault(x => x.nameSupplier == Constants.Constants.CoopMart);
                if (coopMart == null)
                {
                    coopMart = new Supplier
                    {
                        nameSupplier = Constants.Constants.CoopMart,
                        address = "200, Trần Hưng Đạo, Cao Lãnh, Đồng Tháp",
                        phoneNumber = "1111111111"
                    };
                    context.Suppliers.Add(coopMart);
                    context.SaveChanges();
                }

                // Insert Info For Table Area
                var areaNormal = context.Areas.FirstOrDefault(x => x.nameArea == Constants.Constants.areaNormal);
                if (areaNormal == null)
                {
                    areaNormal = new Area
                    {
                        nameArea = Constants.Constants.areaNormal,
                    };
                    context.Areas.Add(areaNormal);
                    context.SaveChanges();
                }

                var areaVIP = context.Areas.FirstOrDefault(x => x.nameArea == Constants.Constants.areaVIP);
                if (areaVIP == null)
                {
                    areaVIP = new Area
                    {
                        nameArea = Constants.Constants.areaVIP,
                    };
                    context.Areas.Add(areaVIP);
                    context.SaveChanges();
                }

                // Insert Info For Table Tables
                var tbNor1 = context.Tables.FirstOrDefault(x => x.nameTable == Constants.Constants.tbNor1);
                if (tbNor1 == null)
                {
                    tbNor1 = new Tables
                    {
                        nameTable = Constants.Constants.tbNor1,
                        status = false
                    };

                    var _areaNormal = context.Areas.FirstOrDefault(x => x.nameArea == Constants.Constants.areaNormal);
                    if (_areaNormal != null)
                    {
                        tbNor1.Area = _areaNormal;
                        context.Tables.Add(tbNor1);
                        context.SaveChanges();
                    }
                }

                var tbNor2 = context.Tables.FirstOrDefault(x => x.nameTable == Constants.Constants.tbNor2);
                if (tbNor2 == null)
                {
                    tbNor2 = new Tables
                    {
                        nameTable = Constants.Constants.tbNor2,
                        status = false
                    };

                    var _areaNormal = context.Areas.FirstOrDefault(x => x.nameArea == Constants.Constants.areaNormal);
                    if (_areaNormal != null)
                    {
                        tbNor2.Area = _areaNormal;
                        context.Tables.Add(tbNor2);
                        context.SaveChanges();
                    }
                }

                var tbNor3 = context.Tables.FirstOrDefault(x => x.nameTable == Constants.Constants.tbNor3);
                if (tbNor3 == null)
                {
                    tbNor3 = new Tables
                    {
                        nameTable = Constants.Constants.tbNor3,
                        status = false
                    };

                    var _areaNormal = context.Areas.FirstOrDefault(x => x.nameArea == Constants.Constants.areaNormal);
                    if (_areaNormal != null)
                    {
                        tbNor3.Area = _areaNormal;
                        context.Tables.Add(tbNor3);
                        context.SaveChanges();
                    }
                }

                var tbNor4 = context.Tables.FirstOrDefault(x => x.nameTable == Constants.Constants.tbNor4);
                if (tbNor4 == null)
                {
                    tbNor4 = new Tables
                    {
                        nameTable = Constants.Constants.tbNor4,
                        status = false
                    };

                    var _areaNormal = context.Areas.FirstOrDefault(x => x.nameArea == Constants.Constants.areaNormal);
                    if (_areaNormal != null)
                    {
                        tbNor4.Area = _areaNormal;
                        context.Tables.Add(tbNor4);
                        context.SaveChanges();
                    }
                }

                var tbNor5 = context.Tables.FirstOrDefault(x => x.nameTable == Constants.Constants.tbNor5);
                if (tbNor5 == null)
                {
                    tbNor5 = new Tables
                    {
                        nameTable = Constants.Constants.tbNor5,
                        status = false
                    };

                    var _areaNormal = context.Areas.FirstOrDefault(x => x.nameArea == Constants.Constants.areaNormal);
                    if (_areaNormal != null)
                    {
                        tbNor5.Area = _areaNormal;
                        context.Tables.Add(tbNor5);
                        context.SaveChanges();
                    }
                }

                var tbNor6 = context.Tables.FirstOrDefault(x => x.nameTable == Constants.Constants.tbNor6);
                if (tbNor6 == null)
                {
                    tbNor6 = new Tables
                    {
                        nameTable = Constants.Constants.tbNor6,
                        status = false
                    };

                    var _areaNormal = context.Areas.FirstOrDefault(x => x.nameArea == Constants.Constants.areaNormal);
                    if (_areaNormal != null)
                    {
                        tbNor6.Area = _areaNormal;
                        context.Tables.Add(tbNor6);
                        context.SaveChanges();
                    }
                }

                var tbNor7 = context.Tables.FirstOrDefault(x => x.nameTable == Constants.Constants.tbNor7);
                if (tbNor7 == null)
                {
                    tbNor7 = new Tables
                    {
                        nameTable = Constants.Constants.tbNor7,
                        status = false
                    };

                    var _areaNormal = context.Areas.FirstOrDefault(x => x.nameArea == Constants.Constants.areaNormal);
                    if (_areaNormal != null)
                    {
                        tbNor7.Area = _areaNormal;
                        context.Tables.Add(tbNor7);
                        context.SaveChanges();
                    }
                }

                var tbNor8 = context.Tables.FirstOrDefault(x => x.nameTable == Constants.Constants.tbNor8);
                if (tbNor8 == null)
                {
                    tbNor8 = new Tables
                    {
                        nameTable = Constants.Constants.tbNor8,
                        status = false
                    };

                    var _areaNormal = context.Areas.FirstOrDefault(x => x.nameArea == Constants.Constants.areaNormal);
                    if (_areaNormal != null)
                    {
                        tbNor8.Area = _areaNormal;
                        context.Tables.Add(tbNor8);
                        context.SaveChanges();
                    }
                }

                var tbNor9 = context.Tables.FirstOrDefault(x => x.nameTable == Constants.Constants.tbNor9);
                if (tbNor9 == null)
                {
                    tbNor9 = new Tables
                    {
                        nameTable = Constants.Constants.tbNor9,
                        status = false
                    };

                    var _areaNormal = context.Areas.FirstOrDefault(x => x.nameArea == Constants.Constants.areaNormal);
                    if (_areaNormal != null)
                    {
                        tbNor9.Area = _areaNormal;
                        context.Tables.Add(tbNor9);
                        context.SaveChanges();
                    }
                }

                var tbNor10 = context.Tables.FirstOrDefault(x => x.nameTable == Constants.Constants.tbNor10);
                if (tbNor10 == null)
                {
                    tbNor10 = new Tables
                    {
                        nameTable = Constants.Constants.tbNor10,
                        status = false
                    };

                    var _areaNormal = context.Areas.FirstOrDefault(x => x.nameArea == Constants.Constants.areaNormal);
                    if (_areaNormal != null)
                    {
                        tbNor10.Area = _areaNormal;
                        context.Tables.Add(tbNor10);
                        context.SaveChanges();
                    }
                }


                var tbNor11 = context.Tables.FirstOrDefault(x => x.nameTable == Constants.Constants.tbNor11);
                if (tbNor11 == null)
                {
                    tbNor11 = new Tables
                    {
                        nameTable = Constants.Constants.tbNor11,
                        status = false
                    };

                    var _areaNormal = context.Areas.FirstOrDefault(x => x.nameArea == Constants.Constants.areaNormal);
                    if (_areaNormal != null)
                    {
                        tbNor11.Area = _areaNormal;
                        context.Tables.Add(tbNor11);
                        context.SaveChanges();
                    }
                }

                var tbNor12 = context.Tables.FirstOrDefault(x => x.nameTable == Constants.Constants.tbNor12);
                if (tbNor12 == null)
                {
                    tbNor12 = new Tables
                    {
                        nameTable = Constants.Constants.tbNor12,
                        status = false
                    };

                    var _areaNormal = context.Areas.FirstOrDefault(x => x.nameArea == Constants.Constants.areaNormal);
                    if (_areaNormal != null)
                    {
                        tbNor12.Area = _areaNormal;
                        context.Tables.Add(tbNor12);
                        context.SaveChanges();
                    }
                }

                var tbNor13 = context.Tables.FirstOrDefault(x => x.nameTable == Constants.Constants.tbNor13);
                if (tbNor13 == null)
                {
                    tbNor13 = new Tables
                    {
                        nameTable = Constants.Constants.tbNor13,
                        status = false
                    };

                    var _areaNormal = context.Areas.FirstOrDefault(x => x.nameArea == Constants.Constants.areaNormal);
                    if (_areaNormal != null)
                    {
                        tbNor13.Area = _areaNormal;
                        context.Tables.Add(tbNor13);
                        context.SaveChanges();
                    }
                }

                var tbNor14 = context.Tables.FirstOrDefault(x => x.nameTable == Constants.Constants.tbNor14);
                if (tbNor14 == null)
                {
                    tbNor14 = new Tables
                    {
                        nameTable = Constants.Constants.tbNor14,
                        status = false
                    };

                    var _areaNormal = context.Areas.FirstOrDefault(x => x.nameArea == Constants.Constants.areaNormal);
                    if (_areaNormal != null)
                    {
                        tbNor14.Area = _areaNormal;
                        context.Tables.Add(tbNor14);
                        context.SaveChanges();
                    }
                }

                var tbNor15 = context.Tables.FirstOrDefault(x => x.nameTable == Constants.Constants.tbNor15);
                if (tbNor15 == null)
                {
                    tbNor15 = new Tables
                    {
                        nameTable = Constants.Constants.tbNor15,
                        status = false
                    };

                    var _areaNormal = context.Areas.FirstOrDefault(x => x.nameArea == Constants.Constants.areaNormal);
                    if (_areaNormal != null)
                    {
                        tbNor15.Area = _areaNormal;
                        context.Tables.Add(tbNor15);
                        context.SaveChanges();
                    }
                }

                var tbVIP1 = context.Tables.FirstOrDefault(x => x.nameTable == Constants.Constants.tbVIP1);
                if (tbVIP1 == null)
                {
                    tbVIP1 = new Tables
                    {
                        nameTable = Constants.Constants.tbVIP1,
                        status = false
                    };

                    var _areaVIP = context.Areas.FirstOrDefault(x => x.nameArea == Constants.Constants.areaVIP);
                    if (_areaVIP != null)
                    {
                        tbVIP1.Area = _areaVIP;
                        context.Tables.Add(tbVIP1);
                        context.SaveChanges();
                    }
                }

                var tbVIP2 = context.Tables.FirstOrDefault(x => x.nameTable == Constants.Constants.tbVIP2);
                if (tbVIP2 == null)
                {
                    tbVIP2 = new Tables
                    {
                        nameTable = Constants.Constants.tbVIP2,
                        status = false
                    };

                    var _areaVIP = context.Areas.FirstOrDefault(x => x.nameArea == Constants.Constants.areaVIP);
                    if (_areaVIP != null)
                    {
                        tbVIP2.Area = _areaVIP;
                        context.Tables.Add(tbVIP2);
                        context.SaveChanges();
                    }
                }

                var tbVIP3 = context.Tables.FirstOrDefault(x => x.nameTable == Constants.Constants.tbVIP3);
                if (tbVIP3 == null)
                {
                    tbVIP3 = new Tables
                    {
                        nameTable = Constants.Constants.tbVIP3,
                        status = false
                    };

                    var _areaVIP = context.Areas.FirstOrDefault(x => x.nameArea == Constants.Constants.areaVIP);
                    if (_areaVIP != null)
                    {
                        tbVIP3.Area = _areaVIP;
                        context.Tables.Add(tbVIP3);
                        context.SaveChanges();
                    }
                }

                var tbVIP4 = context.Tables.FirstOrDefault(x => x.nameTable == Constants.Constants.tbVIP4);
                if (tbVIP4 == null)
                {
                    tbVIP4 = new Tables
                    {
                        nameTable = Constants.Constants.tbVIP4,
                        status = false
                    };

                    var _areaVIP = context.Areas.FirstOrDefault(x => x.nameArea == Constants.Constants.areaVIP);
                    if (_areaVIP != null)
                    {
                        tbVIP4.Area = _areaVIP;
                        context.Tables.Add(tbVIP4);
                        context.SaveChanges();
                    }
                }

                var tbVIP5 = context.Tables.FirstOrDefault(x => x.nameTable == Constants.Constants.tbVIP5);
                if (tbVIP5 == null)
                {
                    tbVIP5 = new Tables
                    {
                        nameTable = Constants.Constants.tbVIP5,
                        status = false
                    };

                    var _areaVIP = context.Areas.FirstOrDefault(x => x.nameArea == Constants.Constants.areaVIP);
                    if (_areaVIP != null)
                    {
                        tbVIP5.Area = _areaVIP;
                        context.Tables.Add(tbVIP5);
                        context.SaveChanges();
                    }
                }

                var tbVIP6 = context.Tables.FirstOrDefault(x => x.nameTable == Constants.Constants.tbVIP6);
                if (tbVIP6 == null)
                {
                    tbVIP6 = new Tables
                    {
                        nameTable = Constants.Constants.tbVIP6,
                        status = false
                    };

                    var _areaVIP = context.Areas.FirstOrDefault(x => x.nameArea == Constants.Constants.areaVIP);
                    if (_areaVIP != null)
                    {
                        tbVIP6.Area = _areaVIP;
                        context.Tables.Add(tbVIP6);
                        context.SaveChanges();
                    }
                }

                var tbVIP7 = context.Tables.FirstOrDefault(x => x.nameTable == Constants.Constants.tbVIP7);
                if (tbVIP7 == null)
                {
                    tbVIP7 = new Tables
                    {
                        nameTable = Constants.Constants.tbVIP7,
                        status = false
                    };

                    var _areaVIP = context.Areas.FirstOrDefault(x => x.nameArea == Constants.Constants.areaVIP);
                    if (_areaVIP != null)
                    {
                        tbVIP7.Area = _areaVIP;
                        context.Tables.Add(tbVIP7);
                        context.SaveChanges();
                    }
                }

                var tbVIP8 = context.Tables.FirstOrDefault(x => x.nameTable == Constants.Constants.tbVIP8);
                if (tbVIP8 == null)
                {
                    tbVIP8 = new Tables
                    {
                        nameTable = Constants.Constants.tbVIP8,
                        status = false
                    };

                    var _areaVIP = context.Areas.FirstOrDefault(x => x.nameArea == Constants.Constants.areaVIP);
                    if (_areaVIP != null)
                    {
                        tbVIP8.Area = _areaVIP;
                        context.Tables.Add(tbVIP8);
                        context.SaveChanges();
                    }
                }

                var tbVIP9 = context.Tables.FirstOrDefault(x => x.nameTable == Constants.Constants.tbVIP9);
                if (tbVIP9 == null)
                {
                    tbVIP9 = new Tables
                    {
                        nameTable = Constants.Constants.tbVIP9,
                        status = false
                    };

                    var _areaVIP = context.Areas.FirstOrDefault(x => x.nameArea == Constants.Constants.areaVIP);
                    if (_areaVIP != null)
                    {
                        tbVIP9.Area = _areaVIP;
                        context.Tables.Add(tbVIP9);
                        context.SaveChanges();
                    }
                }

                var tbVIP10 = context.Tables.FirstOrDefault(x => x.nameTable == Constants.Constants.tbVIP10);
                if (tbVIP10 == null)
                {
                    tbVIP10 = new Tables
                    {
                        nameTable = Constants.Constants.tbVIP10,
                        status = false
                    };

                    var _areaVIP = context.Areas.FirstOrDefault(x => x.nameArea == Constants.Constants.areaVIP);
                    if (_areaVIP != null)
                    {
                        tbVIP10.Area = _areaVIP;
                        context.Tables.Add(tbVIP10);
                        context.SaveChanges();
                    }
                }

                var checkVinMart = context.Suppliers.FirstOrDefault(x => x.nameSupplier == Constants.Constants.vinMART);
                var checkCoopMart = context.Suppliers.FirstOrDefault(x => x.nameSupplier == Constants.Constants.CoopMart);

                // Insert info Table RawMaterial
                var sugar = new RawMaterial
                {
                    nameRawMaterial = "Đường",
                    priceRawMaterial = 10000,
                    InventoryNumber = 100,
                };

                var kilo = context.Units.FirstOrDefault(x => x.nameUnit == Constants.Constants.kilogram);
                if (kilo != null)
                {
                    sugar.Unit = kilo;
                    sugar.Suppliers = new List<Supplier>();
                    var sup = checkCoopMart;
                    sugar.Suppliers.Add(sup);
                    context.RawMaterials.Add(sugar);
                    context.SaveChanges();
                }

                var sugarBlack = new RawMaterial
                {
                    nameRawMaterial = "Đường Đen",
                    priceRawMaterial = 10000,
                    InventoryNumber = 100,
                };

                // var kilo = context.Units.FirstOrDefault(x => x.nameUnit == Constants.Constants.kilogram);
                if (kilo != null)
                {
                    sugarBlack.Unit = kilo;
                    sugarBlack.Suppliers = new List<Supplier>();
                    var sup = checkCoopMart;
                    sugarBlack.Suppliers.Add(sup);
                    context.RawMaterials.Add(sugarBlack);
                    context.SaveChanges();
                }

                var milkSugar = new RawMaterial
                {
                    nameRawMaterial = "Sữa có đường",
                    priceRawMaterial = 10000,
                    InventoryNumber = 100,
                };

                var MilkContainer = context.Units.FirstOrDefault(x => x.nameUnit == Constants.Constants.container);
                if (MilkContainer != null)
                {
                    milkSugar.Unit = MilkContainer;
                    milkSugar.Suppliers = new List<Supplier>();
                    var sup = checkCoopMart;
                    milkSugar.Suppliers.Add(sup);
                    context.RawMaterials.Add(milkSugar);
                    context.SaveChanges();
                }

                var milkNoSugar = new RawMaterial
                {
                    nameRawMaterial = "Sữa không đường",
                    priceRawMaterial = 10000,
                    InventoryNumber = 100,
                };

                // var Milkcan = context.Units.FirstOrDefault(x => x.nameUnit == Constants.Constants.aCan);
                if (MilkContainer != null)
                {
                    milkNoSugar.Unit = MilkContainer;
                    milkNoSugar.Suppliers = new List<Supplier>();
                    var sup = checkCoopMart;
                    milkNoSugar.Suppliers.Add(sup);
                    context.RawMaterials.Add(milkNoSugar);
                    context.SaveChanges();
                }

                var aSting = new RawMaterial
                {
                    nameRawMaterial = "Sting Đỏ",
                    priceRawMaterial = 10000,
                    InventoryNumber = 100
                };

                var can = context.Units.FirstOrDefault(x => x.nameUnit == Constants.Constants.aCan);
                if (can != null)
                {
                    aSting.Unit = can;
                    aSting.Suppliers = new List<Supplier>();
                    var sup = checkCoopMart;
                    aSting.Suppliers.Add(sup);
                    context.RawMaterials.Add(aSting);
                    context.SaveChanges();
                }

                var aStingYell = new RawMaterial
                {
                    nameRawMaterial = "Sting Vàng",
                    priceRawMaterial = 10000,
                    InventoryNumber = 200
                };

                // var can = context.Units.FirstOrDefault(x => x.nameUnit == Constants.Constants.aCan);
                if (can != null)
                {
                    aStingYell.Unit = can;
                    context.RawMaterials.Add(aStingYell);
                    context.SaveChanges();
                }

                var aStingGreen = new RawMaterial
                {
                    nameRawMaterial = "Sting Xanh",
                    priceRawMaterial = 10000,
                    InventoryNumber = 300
                };

                // var can = context.Units.FirstOrDefault(x => x.nameUnit == Constants.Constants.aCan);
                if (can != null)
                {
                    aStingGreen.Unit = can;
                    aStingGreen.Suppliers = new List<Supplier>();
                    var sup = checkCoopMart;
                    aStingGreen.Suppliers.Add(sup);
                    context.RawMaterials.Add(aStingGreen);
                    context.SaveChanges();
                }

                var cafeArabica = new RawMaterial
                {
                    nameRawMaterial = "Cafe Arabica",
                    priceRawMaterial = 500000,
                    InventoryNumber = 50
                };

                if (kilo != null)
                {
                    cafeArabica.Unit = kilo;
                    cafeArabica.Suppliers = new List<Supplier>();
                    var sup = checkVinMart;
                    cafeArabica.Suppliers.Add(sup);
                    context.RawMaterials.Add(cafeArabica);
                    context.SaveChanges();
                }

                var cafeRobusta = new RawMaterial
                {
                    nameRawMaterial = "Cafe Robusta",
                    priceRawMaterial = 600000,
                    InventoryNumber = 100
                };

                if (kilo != null)
                {
                    cafeRobusta.Unit = kilo;
                    cafeRobusta.Suppliers = new List<Supplier>();
                    var sup = checkVinMart;
                    cafeRobusta.Suppliers.Add(sup);
                    context.RawMaterials.Add(cafeRobusta);
                    context.SaveChanges();
                }

                var cafeCuli = new RawMaterial
                {
                    nameRawMaterial = "Cafe Culi",
                    priceRawMaterial = 700000,
                    InventoryNumber = 100
                };

                if (kilo != null)
                {
                    cafeCuli.Unit = kilo;
                    cafeCuli.Suppliers = new List<Supplier>();
                    var sup = checkVinMart;
                    cafeCuli.Suppliers.Add(sup);
                    context.RawMaterials.Add(cafeCuli);
                    context.SaveChanges();
                }

                var cafeCherry = new RawMaterial
                {
                    nameRawMaterial = "Cafe Cherry",
                    priceRawMaterial = 800000,
                    InventoryNumber = 100,

                };

                if (kilo != null)
                {
                    cafeCherry.Unit = kilo;
                    cafeCherry.Suppliers = new List<Supplier>();
                    var sup = checkVinMart;
                    cafeCherry.Suppliers.Add(sup);
                    context.RawMaterials.Add(cafeCherry);
                    context.SaveChanges();
                }

                // Insert Infor ProductType
                var Juice = context.ProductTypes.FirstOrDefault(x => x.nameProductType == Constants.Constants.Juice);
                if (Juice == null)
                {
                    Juice = new ProductType
                    {
                        nameProductType = Constants.Constants.Juice
                    };
                    context.ProductTypes.Add(Juice);
                    context.SaveChanges();
                }

                var IceDrink = context.ProductTypes.FirstOrDefault(x => x.nameProductType == Constants.Constants.IceDrink);
                if (IceDrink == null)
                {
                    IceDrink = new ProductType
                    {
                        nameProductType = Constants.Constants.IceDrink
                    };
                    context.ProductTypes.Add(IceDrink);
                    context.SaveChanges();
                }

                var MilkTea = context.ProductTypes.FirstOrDefault(x => x.nameProductType == Constants.Constants.MilkTea);
                if (MilkTea == null)
                {
                    MilkTea = new ProductType
                    {
                        nameProductType = Constants.Constants.MilkTea
                    };
                    context.ProductTypes.Add(MilkTea);
                    context.SaveChanges();
                }

                var Coffee = context.ProductTypes.FirstOrDefault(x => x.nameProductType == Constants.Constants.Coffee);
                if (Coffee == null)
                {
                    Coffee = new ProductType
                    {
                        nameProductType = Constants.Constants.Coffee
                    };
                    context.ProductTypes.Add(Coffee);
                    context.SaveChanges();
                }

                //var Soda = context.ProductTypes.FirstOrDefault(x => x.nameProductType == Constants.Constants.Soda);
                //if (Soda == null)
                //{
                //    Soda = new ProductType
                //    {
                //        nameProductType = Constants.Constants.Soda
                //    };
                //    context.ProductTypes.Add(Soda);
                //    context.SaveChanges();
                //}

                var CakeSnack = context.ProductTypes.FirstOrDefault(x => x.nameProductType == Constants.Constants.CakeSnack);
                if (CakeSnack == null)
                {
                    CakeSnack = new ProductType
                    {
                        nameProductType = Constants.Constants.CakeSnack
                    };
                    context.ProductTypes.Add(CakeSnack);
                    context.SaveChanges();
                }

                //INSERT INFOR PRODUCTS
                // COFFEE
                var cf1 = context.Products.FirstOrDefault(x => x.nameProduct == Constants.Constants.cf1);
                if (cf1 == null)
                {
                    cf1 = new Product
                    {
                        nameProduct = Constants.Constants.cf1,
                        pathImage = Constants.Constants.cf1,
                        priceProduct = 39000,
                    };
                    cf1.ProductType = Coffee;
                    cf1.Unit = aGlass;
                    context.Products.Add(cf1);
                    context.SaveChanges();
                }

                var cf2 = context.Products.FirstOrDefault(x => x.nameProduct == Constants.Constants.cf2);
                if (cf2 == null)
                {
                    cf2 = new Product
                    {
                        nameProduct = Constants.Constants.cf2,
                        pathImage = Constants.Constants.cf2,
                        priceProduct = 29000,
                    };
                    cf2.ProductType = Coffee;
                    cf2.Unit = aGlass;
                    context.Products.Add(cf2);
                    context.SaveChanges();
                }

                var cf3 = context.Products.FirstOrDefault(x => x.nameProduct == Constants.Constants.cf3);
                if (cf3 == null)
                {
                    cf3 = new Product
                    {
                        nameProduct = Constants.Constants.cf3,
                        pathImage = Constants.Constants.cf3,
                        priceProduct = 29000,
                    };
                    cf3.ProductType = Coffee;
                    cf3.Unit = aGlass;
                    context.Products.Add(cf3);
                    context.SaveChanges();
                }

                var cf4 = context.Products.FirstOrDefault(x => x.nameProduct == Constants.Constants.cf4);
                if (cf4 == null)
                {
                    cf4 = new Product
                    {
                        nameProduct = Constants.Constants.cf4,
                        pathImage = Constants.Constants.cf4,
                        priceProduct = 29000,
                    };
                    cf4.ProductType = Coffee;
                    cf4.Unit = aGlass;
                    context.Products.Add(cf4);
                    context.SaveChanges();
                }

                var cf5 = context.Products.FirstOrDefault(x => x.nameProduct == Constants.Constants.cf5);
                if (cf5 == null)
                {
                    cf5 = new Product
                    {
                        nameProduct = Constants.Constants.cf5,
                        pathImage = Constants.Constants.cf5,
                        priceProduct = 45000,
                    };
                    cf5.ProductType = Coffee;
                    cf5.Unit = aGlass;
                    context.Products.Add(cf5);
                    context.SaveChanges();
                }

                var cf6 = context.Products.FirstOrDefault(x => x.nameProduct == Constants.Constants.cf6);
                if (cf6 == null)
                {
                    cf6 = new Product
                    {
                        nameProduct = Constants.Constants.cf6,
                        pathImage = Constants.Constants.cf6,
                        priceProduct = 55000,
                    };
                    cf6.ProductType = Coffee;
                    cf6.Unit = aGlass;
                    context.Products.Add(cf6);
                    context.SaveChanges();
                }

                var cf7 = context.Products.FirstOrDefault(x => x.nameProduct == Constants.Constants.cf7);
                if (cf7 == null)
                {
                    cf7 = new Product
                    {
                        nameProduct = Constants.Constants.cf7,
                        pathImage = Constants.Constants.cf7,
                        priceProduct = 45000,
                    };
                    cf7.ProductType = Coffee;
                    cf7.Unit = aGlass;
                    context.Products.Add(cf7);
                    context.SaveChanges();
                }

                var cf8 = context.Products.FirstOrDefault(x => x.nameProduct == Constants.Constants.cf8);
                if (cf8 == null)
                {
                    cf8 = new Product
                    {
                        nameProduct = Constants.Constants.cf8,
                        pathImage = Constants.Constants.cf8,
                        priceProduct = 50000,
                    };
                    cf8.ProductType = Coffee;
                    cf8.Unit = aGlass;
                    context.Products.Add(cf8);
                    context.SaveChanges();
                }

                var cf9 = context.Products.FirstOrDefault(x => x.nameProduct == Constants.Constants.cf9);
                if (cf9 == null)
                {
                    cf9 = new Product
                    {
                        nameProduct = Constants.Constants.cf9,
                        pathImage = Constants.Constants.cf9,
                        priceProduct = 50000,
                    };
                    cf9.ProductType = Coffee;
                    cf9.Unit = aGlass;
                    context.Products.Add(cf9);
                    context.SaveChanges();
                }

                var cf10 = context.Products.FirstOrDefault(x => x.nameProduct == Constants.Constants.cf10);
                if (cf10 == null)
                {
                    cf10 = new Product
                    {
                        nameProduct = Constants.Constants.cf10,
                        pathImage = Constants.Constants.cf10,
                        priceProduct = 50000,
                    };
                    cf10.ProductType = Coffee;
                    cf10.Unit = aGlass;
                    context.Products.Add(cf10);
                    context.SaveChanges();
                }

                var cf11 = context.Products.FirstOrDefault(x => x.nameProduct == Constants.Constants.cf11);
                if (cf11 == null)
                {
                    cf11 = new Product
                    {
                        nameProduct = Constants.Constants.cf11,
                        pathImage = Constants.Constants.cf11,
                        priceProduct = 45000,
                    };
                    cf11.ProductType = Coffee;
                    cf11.Unit = aGlass;
                    context.Products.Add(cf11);
                    context.SaveChanges();
                }

                var cf12 = context.Products.FirstOrDefault(x => x.nameProduct == Constants.Constants.cf12);
                if (cf12 == null)
                {
                    cf12 = new Product
                    {
                        nameProduct = Constants.Constants.cf12,
                        pathImage = Constants.Constants.cf12,
                        priceProduct = 35000,
                    };
                    cf12.ProductType = Coffee;
                    cf12.Unit = aGlass;
                    context.Products.Add(cf12);
                    context.SaveChanges();
                }

                var cf13 = context.Products.FirstOrDefault(x => x.nameProduct == Constants.Constants.cf13);
                if (cf13 == null)
                {
                    cf13 = new Product
                    {
                        nameProduct = Constants.Constants.cf13,
                        pathImage = Constants.Constants.cf13,
                        priceProduct = 45000,
                    };
                    cf13.ProductType = Coffee;
                    cf13.Unit = aGlass;
                    context.Products.Add(cf13);
                    context.SaveChanges();
                }

                var cf14 = context.Products.FirstOrDefault(x => x.nameProduct == Constants.Constants.cf14);
                if (cf14 == null)
                {
                    cf14 = new Product
                    {
                        nameProduct = Constants.Constants.cf14,
                        pathImage = Constants.Constants.cf14,
                        priceProduct = 49000,
                    };
                    cf14.ProductType = Coffee;
                    cf14.Unit = aGlass;
                    context.Products.Add(cf14);
                    context.SaveChanges();
                }

                var cf15 = context.Products.FirstOrDefault(x => x.nameProduct == Constants.Constants.cf15);
                if (cf15 == null)
                {
                    cf15 = new Product
                    {
                        nameProduct = Constants.Constants.cf15,
                        pathImage = Constants.Constants.cf15,
                        priceProduct = 55000,
                    };
                    cf15.ProductType = Coffee;
                    cf15.Unit = aGlass;
                    context.Products.Add(cf15);
                    context.SaveChanges();
                }

                // Tea & MACCHIATO
                var tm1 = context.Products.FirstOrDefault(x => x.nameProduct == Constants.Constants.tm1);
                if (tm1 == null)
                {
                    tm1 = new Product
                    {
                        nameProduct = Constants.Constants.tm1,
                        pathImage = Constants.Constants.tm1,
                        priceProduct = 55000,
                    };
                    tm1.ProductType = MilkTea;
                    tm1.Unit = aGlass;
                    context.Products.Add(tm1);
                    context.SaveChanges();
                }

                var tm2 = context.Products.FirstOrDefault(x => x.nameProduct == Constants.Constants.tm2);
                if (tm2 == null)
                {
                    tm2 = new Product
                    {
                        nameProduct = Constants.Constants.tm2,
                        pathImage = Constants.Constants.tm2,
                        priceProduct = 45000,
                    };
                    tm2.ProductType = MilkTea;
                    tm2.Unit = aGlass;
                    context.Products.Add(tm2);
                    context.SaveChanges();
                }

                var tm3 = context.Products.FirstOrDefault(x => x.nameProduct == Constants.Constants.tm3);
                if (tm3 == null)
                {
                    tm3 = new Product
                    {
                        nameProduct = Constants.Constants.tm3,
                        pathImage = Constants.Constants.tm3,
                        priceProduct = 42000,
                    };
                    tm3.ProductType = MilkTea;
                    tm3.Unit = aGlass;
                    context.Products.Add(tm3);
                    context.SaveChanges();
                }

                var tm4 = context.Products.FirstOrDefault(x => x.nameProduct == Constants.Constants.tm4);
                if (tm4 == null)
                {
                    tm4 = new Product
                    {
                        nameProduct = Constants.Constants.tm4,
                        pathImage = Constants.Constants.tm4,
                        priceProduct = 48000,
                    };
                    tm4.ProductType = MilkTea;
                    tm4.Unit = aGlass;
                    context.Products.Add(tm4);
                    context.SaveChanges();
                }

                var tm5 = context.Products.FirstOrDefault(x => x.nameProduct == Constants.Constants.tm5);
                if (tm5 == null)
                {
                    tm5 = new Product
                    {
                        nameProduct = Constants.Constants.tm5,
                        pathImage = Constants.Constants.tm5,
                        priceProduct = 59000,
                    };
                    tm5.ProductType = MilkTea;
                    tm5.Unit = aGlass;
                    context.Products.Add(tm5);
                    context.SaveChanges();
                }

                var tm6 = context.Products.FirstOrDefault(x => x.nameProduct == Constants.Constants.tm6);
                if (tm6 == null)
                {
                    tm6 = new Product
                    {
                        nameProduct = Constants.Constants.tm6,
                        pathImage = Constants.Constants.tm6,
                        priceProduct = 45000,
                    };
                    tm6.ProductType = MilkTea;
                    tm6.Unit = aGlass;
                    context.Products.Add(tm6);
                    context.SaveChanges();
                }

                var tm7 = context.Products.FirstOrDefault(x => x.nameProduct == Constants.Constants.tm7);
                if (tm7 == null)
                {
                    tm7 = new Product
                    {
                        nameProduct = Constants.Constants.tm7,
                        pathImage = Constants.Constants.tm7,
                        priceProduct = 45000,
                    };
                    tm7.ProductType = MilkTea;
                    tm7.Unit = aGlass;
                    context.Products.Add(tm7);
                    context.SaveChanges();
                }

                var tm8 = context.Products.FirstOrDefault(x => x.nameProduct == Constants.Constants.tm8);
                if (tm8 == null)
                {
                    tm8 = new Product
                    {
                        nameProduct = Constants.Constants.tm8,
                        pathImage = Constants.Constants.tm8,
                        priceProduct = 45000,
                    };
                    tm8.ProductType = MilkTea;
                    tm8.Unit = aGlass;
                    context.Products.Add(tm8);
                    context.SaveChanges();
                }

                var tm9 = context.Products.FirstOrDefault(x => x.nameProduct == Constants.Constants.tm9);
                if (tm9 == null)
                {
                    tm9 = new Product
                    {
                        nameProduct = Constants.Constants.tm9,
                        pathImage = Constants.Constants.tm9,
                        priceProduct = 49000,
                    };
                    tm9.ProductType = MilkTea;
                    tm9.Unit = aGlass;
                    context.Products.Add(tm9);
                    context.SaveChanges();
                }

                var tm10 = context.Products.FirstOrDefault(x => x.nameProduct == Constants.Constants.tm10);
                if (tm10 == null)
                {
                    tm10 = new Product
                    {
                        nameProduct = Constants.Constants.tm10,
                        pathImage = Constants.Constants.tm10,
                        priceProduct = 55000,
                    };
                    tm10.ProductType = MilkTea;
                    tm10.Unit = aGlass;
                    context.Products.Add(tm10);
                    context.SaveChanges();
                }

                // ICE DRINK
                var id1 = context.Products.FirstOrDefault(x => x.nameProduct == Constants.Constants.id1);
                if (id1 == null)
                {
                    id1 = new Product
                    {
                        nameProduct = Constants.Constants.id1,
                        pathImage = Constants.Constants.id1,
                        priceProduct = 49000,
                    };
                    id1.ProductType = IceDrink;
                    id1.Unit = aGlass;
                    context.Products.Add(id1);
                    context.SaveChanges();
                }

                var id2 = context.Products.FirstOrDefault(x => x.nameProduct == Constants.Constants.id2);
                if (id2 == null)
                {
                    id2 = new Product
                    {
                        nameProduct = Constants.Constants.id2,
                        pathImage = Constants.Constants.id2,
                        priceProduct = 59000,
                    };
                    id2.ProductType = IceDrink;
                    id2.Unit = aGlass;
                    context.Products.Add(id2);
                    context.SaveChanges();
                }

                var id3 = context.Products.FirstOrDefault(x => x.nameProduct == Constants.Constants.id3);
                if (id3 == null)
                {
                    id3 = new Product
                    {
                        nameProduct = Constants.Constants.id3,
                        pathImage = Constants.Constants.id3,
                        priceProduct = 59000,
                    };
                    id3.ProductType = IceDrink;
                    id3.Unit = aGlass;
                    context.Products.Add(id3);
                    context.SaveChanges();
                }

                var id4 = context.Products.FirstOrDefault(x => x.nameProduct == Constants.Constants.id4);
                if (id4 == null)
                {
                    id4 = new Product
                    {
                        nameProduct = Constants.Constants.id4,
                        pathImage = Constants.Constants.id4,
                        priceProduct = 59000,
                    };
                    id4.ProductType = IceDrink;
                    id4.Unit = aGlass;
                    context.Products.Add(id4);
                    context.SaveChanges();
                }


                var id5 = context.Products.FirstOrDefault(x => x.nameProduct == Constants.Constants.id5);
                if (id5 == null)
                {
                    id5 = new Product
                    {
                        nameProduct = Constants.Constants.id5,
                        pathImage = Constants.Constants.id5,
                        priceProduct = 59000,
                    };
                    id5.ProductType = IceDrink;
                    id5.Unit = aGlass;
                    context.Products.Add(id5);
                    context.SaveChanges();
                }

                var id6 = context.Products.FirstOrDefault(x => x.nameProduct == Constants.Constants.id6);
                if (id6 == null)
                {
                    id6 = new Product
                    {
                        nameProduct = Constants.Constants.id6,
                        pathImage = Constants.Constants.id6,
                        priceProduct = 59000,
                    };
                    id6.ProductType = IceDrink;
                    id6.Unit = aGlass;
                    context.Products.Add(id6);
                    context.SaveChanges();
                }

                var id7 = context.Products.FirstOrDefault(x => x.nameProduct == Constants.Constants.id7);
                if (id7 == null)
                {
                    id7 = new Product
                    {
                        nameProduct = Constants.Constants.id7,
                        pathImage = Constants.Constants.id7,
                        priceProduct = 59000,
                    };
                    id7.ProductType = IceDrink;
                    id7.Unit = aGlass;
                    context.Products.Add(id7);
                    context.SaveChanges();
                }

                // JUICE
                var jui1 = context.Products.FirstOrDefault(x => x.nameProduct == Constants.Constants.jui1);
                if (jui1 == null)
                {
                    jui1 = new Product
                    {
                        nameProduct = Constants.Constants.jui1,
                        pathImage = Constants.Constants.jui1,
                        priceProduct = 59000,
                    };
                    jui1.ProductType = Juice;
                    jui1.Unit = aGlass;
                    context.Products.Add(jui1);
                    context.SaveChanges();
                }

                var jui2 = context.Products.FirstOrDefault(x => x.nameProduct == Constants.Constants.jui2);
                if (jui2 == null)
                {
                    jui2 = new Product
                    {
                        nameProduct = Constants.Constants.jui2,
                        pathImage = Constants.Constants.jui2,
                        priceProduct = 59000,
                    };
                    jui2.ProductType = Juice;
                    jui2.Unit = aGlass;
                    context.Products.Add(jui2);
                    context.SaveChanges();
                }

                // Cake & Snake
                var cs1 = context.Products.FirstOrDefault(x => x.nameProduct == Constants.Constants.cs1);
                if (cs1 == null)
                {
                    cs1 = new Product
                    {
                        nameProduct = Constants.Constants.cs1,
                        pathImage = Constants.Constants.cs1,
                        priceProduct = 29000,
                    };
                    cs1.ProductType = CakeSnack;
                    cs1.Unit = aGlass;
                    context.Products.Add(cs1);
                    context.SaveChanges();
                }

                var cs2 = context.Products.FirstOrDefault(x => x.nameProduct == Constants.Constants.cs2);
                if (cs2 == null)
                {
                    cs2 = new Product
                    {
                        nameProduct = Constants.Constants.cs2,
                        pathImage = Constants.Constants.cs2,
                        priceProduct = 29000,
                    };
                    cs2.ProductType = CakeSnack;
                    cs2.Unit = aGlass;
                    context.Products.Add(cs2);
                    context.SaveChanges();
                }

                var cs3 = context.Products.FirstOrDefault(x => x.nameProduct == Constants.Constants.cs3);
                if (cs3 == null)
                {
                    cs3 = new Product
                    {
                        nameProduct = Constants.Constants.cs3,
                        pathImage = Constants.Constants.cs3,
                        priceProduct = 29000,
                    };
                    cs3.ProductType = CakeSnack;
                    cs3.Unit = aGlass;
                    context.Products.Add(cs3);
                    context.SaveChanges();
                }

                var cs4 = context.Products.FirstOrDefault(x => x.nameProduct == Constants.Constants.cs4);
                if (cs4 == null)
                {
                    cs4 = new Product
                    {
                        nameProduct = Constants.Constants.cs4,
                        pathImage = Constants.Constants.cs4,
                        priceProduct = 39000,
                    };
                    cs4.ProductType = CakeSnack;
                    cs4.Unit = aGlass;
                    context.Products.Add(cs4);
                    context.SaveChanges();
                }


                var cs5 = context.Products.FirstOrDefault(x => x.nameProduct == Constants.Constants.cs5);
                if (cs5 == null)
                {
                    cs5 = new Product
                    {
                        nameProduct = Constants.Constants.cs5,
                        pathImage = Constants.Constants.cs5,
                        priceProduct = 29000,
                    };
                    cs5.ProductType = CakeSnack;
                    cs5.Unit = aGlass;
                    context.Products.Add(cs5);
                    context.SaveChanges();
                }


                var cs6 = context.Products.FirstOrDefault(x => x.nameProduct == Constants.Constants.cs6);
                if (cs6 == null)
                {
                    cs6 = new Product
                    {
                        nameProduct = Constants.Constants.cs6,
                        pathImage = Constants.Constants.cs6,
                        priceProduct = 32000,
                    };
                    cs6.ProductType = CakeSnack;
                    cs6.Unit = aGlass;
                    context.Products.Add(cs6);
                    context.SaveChanges();
                }

                var cs7 = context.Products.FirstOrDefault(x => x.nameProduct == Constants.Constants.cs7);
                if (cs7 == null)
                {
                    cs7 = new Product
                    {
                        nameProduct = Constants.Constants.cs7,
                        pathImage = Constants.Constants.cs7,
                        priceProduct = 29000,
                    };
                    cs7.ProductType = CakeSnack;
                    cs7.Unit = aGlass;
                    context.Products.Add(cs7);
                    context.SaveChanges();
                }

                var cs8 = context.Products.FirstOrDefault(x => x.nameProduct == Constants.Constants.cs8);
                if (cs8 == null)
                {
                    cs8 = new Product
                    {
                        nameProduct = Constants.Constants.cs8,
                        pathImage = Constants.Constants.cs8,
                        priceProduct = 29000,
                    };
                    cs8.ProductType = CakeSnack;
                    cs8.Unit = aGlass;
                    context.Products.Add(cs8);
                    context.SaveChanges();
                }
                base.Seed(context);
            }
        }

    }
}
