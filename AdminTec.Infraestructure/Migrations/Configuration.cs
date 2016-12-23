namespace AdminTec.Infraestructure.Migrations
{
    using Domain.Entities;
    using Domain.Enums;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Context.AdminTecContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Context.AdminTecContext context)
        {
            byte[] Byte = System.Text.Encoding.UTF8.GetBytes("Asdf1234");
            byte[] Key = Guid.NewGuid().ToByteArray();
            string pass = Convert.ToBase64String(Byte.Concat(Key).ToArray());

            pass = pass.Replace("+", "A");
            pass = pass.Replace(@"\", "B");
            pass = pass.Replace(@"/", "C");

            //context.Database.Initialize(true);

            //(@"USE [AdminTec]; EXEC sp_MSforeachtable @command1 = " + "'DBCC CHECKIDENT(''?'', RESEED, 0);" + "';");

            #region users

            List<User> users = new List<User>
                {
                    new User
                    {
                        UserName = "dprensa",
                        Password = pass,
                        FirstName = "Dionny",
                        LastName = "Prensa",
                        RememberMe = false,
                        IsSoftDelete = false,
                        IsActive = true
                    },

                    new User
                    {
                        UserName = "raquino",
                        Password = "as1234df",
                        FirstName = "Ruben",
                        LastName = "Aquino",
                        RememberMe = false,
                        IsSoftDelete = false,
                        IsActive = true
                    },

                    new User
                    {
                        UserName = "rjimenez",
                        Password = "a1s2d3f4",
                        FirstName = "Rafael",
                        LastName = "Jimenez",
                        RememberMe = false,

                        IsActive = true,
                        IsSoftDelete = false,
                        CreatedAt = DateTime.Now.Date,
                        CreatedBy = "System",
                        LastModified = DateTime.Now.Date,
                        ModifiedBy = "System"
                    },
                };

            context.Users.AddRange(users);
            base.Seed(context);

            #endregion users

            #region techs

            List<Technician> techs = new List<Technician>()
                {
                    new Technician
                    {
                        FirstName = "Dionny",
                        LastName ="Prensa",
                        IsActive = true,
                        IsSoftDelete = false,
                        CreatedAt = DateTime.Now.Date,
                        CreatedBy = "System",
                        LastModified = DateTime.Now.Date,
                        ModifiedBy = "System"
                    },
                    new Technician
                    {
                        FirstName = "Ruben",
                        LastName ="Aquino",
                        IsActive = true,
                        IsSoftDelete = false,
                        CreatedAt = DateTime.Now.Date,
                        CreatedBy = "System",
                        LastModified = DateTime.Now.Date,
                        ModifiedBy = "System"
                    },
                    new Technician
                    {
                        FirstName = "Rafael",
                        LastName ="Jimenez",
                        IsActive = true,
                        IsSoftDelete = false,
                        CreatedAt = DateTime.Now.Date,
                        CreatedBy = "System",
                        LastModified = DateTime.Now.Date,
                        ModifiedBy = "System"
                    },
                };

            context.Technicians.AddRange(techs);
            base.Seed(context);

            #endregion techs

            #region Mfp

            List<Equipment> Mfp = new List<Equipment>
                {
                    new Equipment
                    {
                        SerialNumber="E174M911135",
                        TypeMachine = MachineType.Color,
                        Model = "MP C6003",
                        Location = "Direccion Ejecutiva, 4to. piso.",
                        IP = "172.20.19.154",
                        CounterBnWCopies=0,
                        CounterBnWPrints=0,
                        CounterColorCopies=0,
                        CounterColorPrints=0,

                        IsActive = true,
                        IsSoftDelete = false,
                        CreatedAt = DateTime.Now.Date,
                        CreatedBy = "System",
                        LastModified = DateTime.Now.Date,
                        ModifiedBy = "System"
                    },

                    new Equipment
                    {
                        SerialNumber="S9148800509",
                        TypeMachine = MachineType.BnW,
                        Model = "SP 5210spf",
                        Location = "Direccion TI, 2do. piso.",
                        IP = "172.29.16.87",
                        CounterBnWCopies=0,
                        CounterBnWPrints=0,
                        CounterColorCopies=0,
                        CounterColorPrints=0,

                        IsActive = true,
                        IsSoftDelete = false,
                        CreatedAt = DateTime.Now.Date,
                        CreatedBy = "System",
                        LastModified = DateTime.Now.Date,
                        ModifiedBy = "System"
                    },

                    new Equipment
                    {
                        SerialNumber="W916P304630",
                        TypeMachine = MachineType.BnW,
                        Model = "MP 301spf",
                        Location = "Caja, Direccion Financiera, 2do. piso.",
                        IP = "172.29.16.84",
                        CounterBnWCopies=0,
                        CounterBnWPrints=0,
                        CounterColorCopies=0,
                        CounterColorPrints=0,

                        IsActive = true,
                        IsSoftDelete = false,
                        CreatedAt = DateTime.Now.Date,
                        CreatedBy = "System",
                        LastModified = DateTime.Now.Date,
                        ModifiedBy = "System"
                    }
                };

            context.Equipments.AddRange(Mfp);
            base.Seed(context);

            #endregion Mfp

            #region toners

            List<Toner> toners = new List<Toner>
                {
                    //6003
                    new Toner
                    {
                        Code = "841852",
                        Target = 30000,
                        TonerType = TonerType.C,
                        RelatedEquipments = new List<Equipment> { Mfp[0] },
                        IsActive = true,
                        IsSoftDelete = false,
                        CreatedAt = DateTime.Now.Date,
                        CreatedBy = "System",
                        LastModified = DateTime.Now.Date,
                        ModifiedBy = "System"
                    },
                    new Toner
                    {
                        Code = "841851",
                        Target = 30000,
                        TonerType = TonerType.M,
                        RelatedEquipments = new List<Equipment> { Mfp[0] },
                        IsActive = true,
                        IsSoftDelete = false,
                        CreatedAt = DateTime.Now.Date,
                        CreatedBy = "System",
                        LastModified = DateTime.Now.Date,
                        ModifiedBy = "System",
                    },
                    new Toner
                    {
                        Code = "841850",
                        Target = 30000,
                        TonerType = TonerType.Y,
                        RelatedEquipments = new List<Equipment> { Mfp[0] },
                        IsActive = true,
                        IsSoftDelete = false,
                        CreatedAt = DateTime.Now.Date,
                        CreatedBy = "System",
                        LastModified = DateTime.Now.Date,
                        ModifiedBy = "System"
                    },
                    new Toner
                    {
                        Code = "841849",
                        Target = 30000,
                        TonerType = TonerType.K,
                        RelatedEquipments = new List<Equipment> { Mfp[0] },
                        IsActive = true,
                        IsSoftDelete = false,
                        CreatedAt = DateTime.Now.Date,
                        CreatedBy = "System",
                        LastModified = DateTime.Now.Date,
                        ModifiedBy = "System"
                    },

                    //5210
                    new Toner
                    {
                        Code = "406683",
                        Target = 8000,
                        TonerType = TonerType.K,
                        RelatedEquipments = new List<Equipment> { Mfp[1] },
                        IsActive = true,
                        IsSoftDelete = false,
                        CreatedAt = DateTime.Now.Date,
                        CreatedBy = "System",
                        LastModified = DateTime.Now.Date,
                        ModifiedBy = "System",
                    },

                    //301
                    new Toner
                    {
                        Code = "841767",
                        Target = 15000,
                        TonerType = TonerType.K,
                        RelatedEquipments = new List<Equipment> { Mfp[2] },
                        IsActive = true,
                        IsSoftDelete = false,
                        CreatedAt = DateTime.Now.Date,
                        CreatedBy = "System",
                        LastModified = DateTime.Now.Date,
                        ModifiedBy = "System",
                    }
                };

            context.Toners.AddRange(toners);
            base.Seed(context);

            #endregion toners

            #region stock

            List<Stock> stock = new List<Stock>
            {
                #region MFP

                new Stock
                {
                    QuantityInInStock = 0,
                    QuantityUsed = 1,
                    Equipment = Mfp[0],
                    EquipmentId = Mfp[0].Id,
                    CreatedAt = DateTime.Now.Date,
                    CreatedBy = "System",
                    LastModified = DateTime.Now.Date,
                    ModifiedBy = "System"
                },

                new Stock
                {
                    QuantityInInStock = 0,
                    QuantityUsed = 1,
                    Equipment = Mfp[1],
                    EquipmentId = Mfp[1].Id,
                    CreatedAt = DateTime.Now.Date,
                    CreatedBy = "System",
                    LastModified = DateTime.Now.Date,
                    ModifiedBy = "System"
                },

                new Stock
                {
                    QuantityInInStock = 0,
                    QuantityUsed = 1,
                    Equipment = Mfp[2],
                    EquipmentId = Mfp[2].Id,
                    CreatedAt = DateTime.Now.Date,
                    CreatedBy = "System",
                    LastModified = DateTime.Now.Date,
                    ModifiedBy = "System",
                },

                #endregion MFP

                #region Toners

                new Stock
                    {
                        QuantityInInStock = 0,
                        QuantityUsed = 1,
                        Toner = toners[0],
                        TonerId = toners[0].TonerId,

                        CreatedAt = DateTime.Now.Date,
                        CreatedBy = "System",
                        LastModified = DateTime.Now.Date,
                        ModifiedBy = "System",
                    },

                new Stock
                    {
                        QuantityInInStock = 0,
                        QuantityUsed = 1,
                        Toner = toners[1],
                        TonerId = toners[1].TonerId,

                        CreatedAt = DateTime.Now.Date,
                        CreatedBy = "System",
                        LastModified = DateTime.Now.Date,
                        ModifiedBy = "System",
                    },

                new Stock
                    {
                        QuantityInInStock = 0,
                        QuantityUsed = 1,
                        Toner = toners[2],
                        TonerId = toners[2].TonerId,

                        CreatedAt = DateTime.Now.Date,
                        CreatedBy = "System",
                        LastModified = DateTime.Now.Date,
                        ModifiedBy = "System",
                    },

                new Stock
                    {
                        QuantityInInStock = 0,
                        QuantityUsed = 1,
                        Toner = toners[3],
                        TonerId = toners[3].TonerId,

                        CreatedAt = DateTime.Now.Date,
                        CreatedBy = "System",
                        LastModified = DateTime.Now.Date,
                        ModifiedBy = "System",
                    },

                new Stock
                    {
                        QuantityInInStock = 0,
                        QuantityUsed = 1,
                        Toner = toners[4],
                        TonerId = toners[4].TonerId,

                        CreatedAt = DateTime.Now.Date,
                        CreatedBy = "System",
                        LastModified = DateTime.Now.Date,
                        ModifiedBy = "System",
                    },

                new Stock
                    {
                        QuantityInInStock = 0,
                        QuantityUsed = 1,
                        Toner = toners[5],
                        TonerId = toners[5].TonerId,

                        CreatedAt = DateTime.Now.Date,
                        CreatedBy = "System",
                        LastModified = DateTime.Now.Date,
                        ModifiedBy = "System",
                    }

                #endregion Toners
            };

            context.Stocks.AddRange(stock);
            base.Seed(context);

            #endregion stock

            #region dStock

            List<DetailStock> dStock = new List<DetailStock>
                {
                    new DetailStock
                    {
                        Stock = stock[0],
                        StockId = stock[0].Id,
                        Quantity = 1,
                        DateOfEntry = DateTime.Now.Date,

                        IsSoftDelete = false,
                        CreatedAt = DateTime.Now.Date,
                        CreatedBy = "System",
                        LastModified = DateTime.Now.Date,
                        ModifiedBy = "System",
                    },

                    new DetailStock
                    {
                        Stock = stock[1],
                        StockId = stock[1].Id,
                        Quantity = 1,
                        DateOfEntry = DateTime.Now.Date,

                        IsSoftDelete = false,
                        CreatedAt = DateTime.Now.Date,
                        CreatedBy = "System",
                        LastModified = DateTime.Now.Date,
                        ModifiedBy = "System",
                    },

                    new DetailStock
                    {
                        Stock = stock[2],
                        StockId = stock[2].Id,
                        Quantity = 1,
                        DateOfEntry = DateTime.Now.Date,

                        IsSoftDelete = false,
                        CreatedAt = DateTime.Now.Date,
                        CreatedBy = "System",
                        LastModified = DateTime.Now.Date,
                        ModifiedBy = "System",
                    },

                    new DetailStock
                    {
                        Stock = stock[3],
                        StockId = stock[3].Id,
                        Quantity = 1,
                        DateOfEntry = DateTime.Now.Date,

                        IsSoftDelete = false,
                        CreatedAt = DateTime.Now.Date,
                        CreatedBy = "System",
                        LastModified = DateTime.Now.Date,
                        ModifiedBy = "System",
                    },

                    new DetailStock
                    {
                        Stock = stock[4],
                        StockId = stock[4].Id,
                        Quantity = 1,
                        DateOfEntry = DateTime.Now.Date,

                        IsSoftDelete = false,
                        CreatedAt = DateTime.Now.Date,
                        CreatedBy = "System",
                        LastModified = DateTime.Now.Date,
                        ModifiedBy = "System",
                    },

                    new DetailStock
                    {
                        Stock = stock[5],
                        StockId = stock[5].Id,
                        Quantity = 1,
                        DateOfEntry = DateTime.Now.Date,

                        IsSoftDelete = false,
                        CreatedAt = DateTime.Now.Date,
                        CreatedBy = "System",
                        LastModified = DateTime.Now.Date,
                        ModifiedBy = "System",
                    },

                    new DetailStock
                    {
                        Stock = stock[6],
                        StockId = stock[6].Id,
                        Quantity = 1,
                        DateOfEntry = DateTime.Now.Date,

                        IsSoftDelete = false,
                        CreatedAt = DateTime.Now.Date,
                        CreatedBy = "System",
                        LastModified = DateTime.Now.Date,
                        ModifiedBy = "System",
                    },

                    new DetailStock
                    {
                        Stock = stock[7],
                        StockId = stock[7].Id,
                        Quantity = 1,
                        DateOfEntry = DateTime.Now.Date,

                        IsSoftDelete = false,
                        CreatedAt = DateTime.Now.Date,
                        CreatedBy = "System",
                        LastModified = DateTime.Now.Date,
                        ModifiedBy = "System",
                    },

                    new DetailStock
                    {
                        Stock = stock[8],
                        StockId = stock[8].Id,
                        Quantity = 1,
                        DateOfEntry = DateTime.Now.Date,

                        IsSoftDelete = false,
                        CreatedAt = DateTime.Now.Date,
                        CreatedBy = "System",
                        LastModified = DateTime.Now.Date,
                        ModifiedBy = "System",
                    }
                };

            context.DetailsStock.AddRange(dStock);
            base.Seed(context);

            #endregion dStock

            #region visits

            List<Visit> visits = new List<Visit>
                {
                    new Visit
                    {
                        VisitType = VisitType.Installation,
                        Equipment = Mfp[0],
                        Technician = techs[0],

                        IsSoftDelete = false,
                        CreatedAt = DateTime.Now.Date.Date,
                        CreatedBy = "System",
                        LastModified = DateTime.Now.Date,
                        ModifiedBy = "System"
                    },

                    new Visit
                    {
                        VisitType = VisitType.Installation,
                        Equipment = Mfp[1],
                        Technician = techs[1],

                        IsSoftDelete = false,
                        CreatedAt = DateTime.Now.Date,
                        CreatedBy = "System",
                        LastModified = DateTime.Now.Date,
                        ModifiedBy = "System"
                    },

                    new Visit
                    {
                        VisitType = VisitType.Installation,
                        Equipment = Mfp[2],
                        Technician = techs[2],

                        IsSoftDelete = false,
                        CreatedAt = DateTime.Now.Date,
                        CreatedBy = "System",
                        LastModified = DateTime.Now.Date,
                        ModifiedBy = "System"
                    },
                };

            context.Visits.AddRange(visits);
            base.Seed(context);

            #endregion visits

            #region dVisits

            List<DetailsVisit> dVisits = new List<DetailsVisit>
                {
                    new DetailsVisit
                    {
                        Visit = visits[0],
                        Comments = "Instalacion de equipo completo con pcc",
                        Toners = new List<Toner>
                        {
                            toners[0],
                            toners[1],
                            toners[2],
                            toners[3],
                        },
                        LastModified = DateTime.Now.Date,
                        ModifiedBy = "System"
                    },

                    new DetailsVisit
                    {
                        Visit = visits[1],
                        Comments = "Instalacion de equipo completo con pcc",
                        Toners = new List<Toner>
                        {
                            toners[4]
                        },
                        LastModified = DateTime.Now.Date,
                        ModifiedBy = "System"
                    },

                    new DetailsVisit
                    {
                        Visit = visits[2],
                        Comments = "Instalacion de equipo completo con pcc",
                        Toners = new List<Toner>
                        {
                            toners[5]
                        },
                        LastModified = DateTime.Now.Date,
                        ModifiedBy = "System"
                    },
                };

            context.DetailsVisit.AddRange(dVisits);
            base.Seed(context);

            #endregion dVisits

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}