namespace AdminTec.Infraestructure.Migrations
{
    using Domain.Entities;
    using Domain.Enums;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Security.Cryptography;

    internal sealed class Configuration : DbMigrationsConfiguration<Context.AdminTecContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        public string hashear(string password)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);

            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            string savedPasswordHash = Convert.ToBase64String(hashBytes);

            return password;
        }

        protected override void Seed(Context.AdminTecContext context)
        {
            context.Database.Initialize(true);
            //context.Database.Create();

            //context.Database.ExecuteSqlCommand(@"USE [AdminTec]; EXEC sp_MSforeachtable @command1 = " + "'DBCC CHECKIDENT(''?'', RESEED, 0);" + "';");

            #region users

            List<User> users = new List<User>
            {
                new User
                {
                    UserName = "dprensa",
                    Password = hashear("asdf1234"),
                    FirstName = "Dionny",
                    LastName = "Prensa",
                    RememberMe = false,
                    IsSoftDelete = false,
                    IsActive = true
                },

                new User
                {
                    UserName = "raquino",
                    Password = hashear("as1234df"),
                    FirstName = "Ruben",
                    LastName = "Aquino",
                    RememberMe = false,
                    IsSoftDelete = false,
                    IsActive = true
                },

                new User
                {
                    UserName = "rjimenez",
                    Password = hashear("a1s2d3f4"),
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

            #endregion Mfp

            #region toners

            List<Toner> toners = new List<Toner>
            {
                new Toner
                {
                    Code = "841767",
                    Target = 15000,
                    TonerType = TonerType.K,

                    IsActive = true,
                    IsSoftDelete = false,
                    CreatedAt = DateTime.Now.Date,
                    CreatedBy = "System",
                    LastModified = DateTime.Now.Date,
                    ModifiedBy = "System",
                },

                new Toner
                {
                    Code = "406683",
                    Target = 8000,
                    TonerType = TonerType.K,

                    IsActive = true,
                    IsSoftDelete = false,
                    CreatedAt = DateTime.Now.Date,
                    CreatedBy = "System",
                    LastModified = DateTime.Now.Date,
                    ModifiedBy = "System",
                },

                new Toner
                {
                    Code = "841849",
                    Target = 30000,
                    TonerType = TonerType.K,

                    IsActive = true,
                    IsSoftDelete = false,
                    CreatedAt = DateTime.Now.Date,
                    CreatedBy = "System",
                    LastModified = DateTime.Now.Date,
                    ModifiedBy = "System",
                },

                new Toner
                {
                    Code = "841852",
                    Target = 30000,
                    TonerType = TonerType.C,

                    IsActive = true,
                    IsSoftDelete = false,
                    CreatedAt = DateTime.Now.Date,
                    CreatedBy = "System",
                    LastModified = DateTime.Now.Date,
                    ModifiedBy = "System",
                },

                new Toner
                {
                    Code = "841851",
                    Target = 30000,
                    TonerType = TonerType.M,

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

                    IsActive = true,
                    IsSoftDelete = false,
                    CreatedAt = DateTime.Now.Date,
                    CreatedBy = "System",
                    LastModified = DateTime.Now.Date,
                    ModifiedBy = "System"
                }
            };

            #endregion toners

            #region stock

            List<Stock> stock = new List<Stock>
            {
                new Stock
                {
                    QuantityInInStock =1,
                    QuantityUsed = 0,
                    Equipment = Mfp[0],
                    EquipmentId = Mfp[0].Id,

                    CreatedAt = DateTime.Now.Date,
                    CreatedBy = "System",
                    LastModified = DateTime.Now.Date,
                    ModifiedBy = "System",
                },

                new Stock
                {
                    QuantityInInStock =1,
                    QuantityUsed = 0,
                    Equipment = Mfp[1],
                    EquipmentId = Mfp[1].Id,

                    CreatedAt = DateTime.Now.Date,
                    CreatedBy = "System",
                    LastModified = DateTime.Now.Date,
                    ModifiedBy = "System",
                },

                new Stock
                {
                    QuantityInInStock =1,
                    QuantityUsed = 0,
                    Equipment = Mfp[2],
                    EquipmentId = Mfp[2].Id,

                    CreatedAt = DateTime.Now.Date,
                    CreatedBy = "System",
                    LastModified = DateTime.Now.Date,
                    ModifiedBy = "System",
                },

                new Stock
                {
                    QuantityInInStock =1,
                    QuantityUsed = 0,
                    Toner = toners[0],
                    TonerId = toners[0].TonerId,

                    CreatedAt = DateTime.Now.Date,
                    CreatedBy = "System",
                    LastModified = DateTime.Now.Date,
                    ModifiedBy = "System",
                },

                new Stock
                {
                    QuantityInInStock =1,
                    QuantityUsed = 0,
                    Toner = toners[1],
                    TonerId = toners[1].TonerId,

                    CreatedAt = DateTime.Now.Date,
                    CreatedBy = "System",
                    LastModified = DateTime.Now.Date,
                    ModifiedBy = "System",
                },

                new Stock
                {
                    QuantityInInStock =1,
                    QuantityUsed = 0,
                    Toner = toners[2],
                    TonerId = toners[2].TonerId,

                    CreatedAt = DateTime.Now.Date,
                    CreatedBy = "System",
                    LastModified = DateTime.Now.Date,
                    ModifiedBy = "System",
                },

                new Stock
                {
                    QuantityInInStock =1,
                    QuantityUsed = 0,
                    Toner = toners[3],
                    TonerId = toners[3].TonerId,

                    CreatedAt = DateTime.Now.Date,
                    CreatedBy = "System",
                    LastModified = DateTime.Now.Date,
                    ModifiedBy = "System",
                },

                new Stock
                {
                    QuantityInInStock =1,
                    QuantityUsed = 0,
                    Toner = toners[4],
                    TonerId = toners[4].TonerId,

                    CreatedAt = DateTime.Now.Date,
                    CreatedBy = "System",
                    LastModified = DateTime.Now.Date,
                    ModifiedBy = "System",
                },

                new Stock
                {
                    QuantityInInStock =1,
                    QuantityUsed = 0,
                    Toner = toners[5],
                    TonerId = toners[5].TonerId,

                    CreatedAt = DateTime.Now.Date,
                    CreatedBy = "System",
                    LastModified = DateTime.Now.Date,
                    ModifiedBy = "System",
                },
            };

            #endregion stock

            #region dStock

            List<DetailStock> dStock = new List<DetailStock>
            {
                new DetailStock
                {
                    Stock = stock[0],
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
                    Quantity = 1,
                    DateOfEntry = DateTime.Now.Date,

                    IsSoftDelete = false,
                    CreatedAt = DateTime.Now.Date,
                    CreatedBy = "System",
                    LastModified = DateTime.Now.Date,
                    ModifiedBy = "System",
                }
            };

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

            #endregion visits

            #region dVisits

            List<DetailVisit> dVisits = new List<DetailVisit>
            {
                new DetailVisit
                {
                    Visit = visits[0],
                    Comments = "Instalacion de equipo completo con pcc",
                    Toners = new List<Toner>
                    {
                        toners[2],
                        toners[3],
                        toners[4],
                        toners[4],
                    }
                },

                new DetailVisit
                {
                    Visit = visits[1],
                    Comments = "Instalacion de equipo completo con pcc",
                    Toners = new List<Toner>
                    {
                        toners[0]
                    }
                },

                new DetailVisit
                {
                    Visit = visits[2],
                    Comments = "Instalacion de equipo completo con pcc",
                    Toners = new List<Toner>
                    {
                        toners[1]
                    }
                },
            };

            #endregion dVisits

            context.Users.AddRange(users);
            base.Seed(context);

            context.Technicians.AddRange(techs);
            base.Seed(context);

            context.Equipments.AddRange(Mfp);
            base.Seed(context);

            context.Toners.AddRange(toners);
            base.Seed(context);

            context.Stocks.AddRange(stock);
            base.Seed(context);

            context.DetailsStock.AddRange(dStock);
            base.Seed(context);

            context.Visits.AddRange(visits);
            base.Seed(context);

            context.DetailsVisit.AddRange(dVisits);

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