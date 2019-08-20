namespace CourseWorkHelsiMSSQL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CourseWorkHelsiMSSQL.Entities.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CourseWorkHelsiMSSQL.Entities.ApplicationDbContext context)
        {
            #region tblCitiesNames - Назви міст
            context.Citiess.AddOrUpdate(f => f.Id,
                new Entities.Cities
                {
                    Id = 1,
                    Name = "Київ"
                });
            context.Citiess.AddOrUpdate(f => f.Id,
                new Entities.Cities
                {
                    Id = 2,
                    Name = "Полтава"
                });
            context.Citiess.AddOrUpdate(f => f.Id,
               new Entities.Cities
               {
                   Id = 3,
                   Name = "Дніпро"
               });
            context.Citiess.AddOrUpdate(f => f.Id,
               new Entities.Cities
               {
                   Id = 4,
                   Name = "Миколаїв"
               });
            context.Citiess.AddOrUpdate(f => f.Id,
               new Entities.Cities
               {
                   Id = 5,
                   Name = "Херсон"
               });
            context.Citiess.AddOrUpdate(f => f.Id,
               new Entities.Cities
               {
                   Id = 6,
                   Name = "Одеса"
               });
            context.Citiess.AddOrUpdate(f => f.Id,
               new Entities.Cities
               {
                   Id = 7,
                   Name = "Рівне"
               });
            context.Citiess.AddOrUpdate(f => f.Id,
               new Entities.Cities
               {
                   Id = 8,
                   Name = "Львів"
               });
            context.Citiess.AddOrUpdate(f => f.Id,
               new Entities.Cities
               {
                   Id = 9,
                   Name = "Запоріжжя"
               });
            context.Citiess.AddOrUpdate(f => f.Id,
               new Entities.Cities
               {
                   Id = 10,
                   Name = "Івано-Франківськ"
               });
            context.Citiess.AddOrUpdate(f => f.Id,
               new Entities.Cities
               {
                   Id = 11,
                   Name = "Кривий Ріг"
               });
            context.Citiess.AddOrUpdate(f => f.Id,
              new Entities.Cities
              {
                  Id = 12,
                  Name = "Суми"
              });
            context.Citiess.AddOrUpdate(f => f.Id,
              new Entities.Cities
              {
                  Id = 13,
                  Name = "Чернівці"
              });
            context.Citiess.AddOrUpdate(f => f.Id,
              new Entities.Cities
              {
                  Id = 14,
                  Name = "Черкаси"
              });
            #endregion
        }
    }
}
