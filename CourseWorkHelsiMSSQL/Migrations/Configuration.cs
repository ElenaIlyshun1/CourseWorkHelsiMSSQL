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

            #region tblDoctors - Список ликарив
            context.Doctors.AddOrUpdate(f => f.Id,
                new Entities.Doctor
                {
                    Id = 1,
                    Name = "Галина",
                    Surname = "Бараболя",
                    Spetialization = "Сімейний лікар",
                    //DateBirthday = 
                });
            context.Doctors.AddOrUpdate(f => f.Id,
               new Entities.Doctor
               {
                   Id = 2,
                   Name = "Ярослав",
                   Surname = "Панчук",
                   Spetialization = "Терапевт",
                   //DateBirthday = 
               });
            context.Doctors.AddOrUpdate(f => f.Id,
                new Entities.Doctor
                {
                    Id = 3,
                    Name = "Олександр",
                    Surname = "Василишин",
                    Spetialization = "Ортопед",
                    //DateBirthday = 
                });
            context.Doctors.AddOrUpdate(f => f.Id,
                new Entities.Doctor
                {
                    Id = 4,
                    Name = "Оксана",
                    Surname = "Костюкович",
                    Spetialization = "Окуліст",
                    //DateBirthday = 
                });
            context.Doctors.AddOrUpdate(f => f.Id,
               new Entities.Doctor
               {
                   Id = 5,
                   Name = "Мирослав",
                   Surname = "Кухарчук",
                   Spetialization = "Хірург",
                   //DateBirthday = 
               });
            context.Doctors.AddOrUpdate(f => f.Id,
                 new Entities.Doctor
                 {
                     Id = 6,
                     Name = "Олег",
                     Surname = "Трохименко",
                     Spetialization = "Отоларинголог",
                     //DateBirthday = 
                 });
            context.Doctors.AddOrUpdate(f => f.Id,
                new Entities.Doctor
                {
                    Id = 7,
                    Name = "Петро",
                    Surname = "Михальчук",
                    Spetialization = "Невропатолог",
                    //DateBirthday = 
                });

            #endregion


        }
    }
}
