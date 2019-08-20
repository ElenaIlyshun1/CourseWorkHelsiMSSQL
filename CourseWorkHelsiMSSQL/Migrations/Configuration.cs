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
            #region tblCitiesNames - ����� ���
            context.Citiess.AddOrUpdate(f => f.Id,
                new Entities.Cities
                {
                    Id = 1,
                    Name = "���"
                });
            context.Citiess.AddOrUpdate(f => f.Id,
                new Entities.Cities
                {
                    Id = 2,
                    Name = "�������"
                });
            context.Citiess.AddOrUpdate(f => f.Id,
               new Entities.Cities
               {
                   Id = 3,
                   Name = "�����"
               });
            context.Citiess.AddOrUpdate(f => f.Id,
               new Entities.Cities
               {
                   Id = 4,
                   Name = "�������"
               });
            context.Citiess.AddOrUpdate(f => f.Id,
               new Entities.Cities
               {
                   Id = 5,
                   Name = "������"
               });
            context.Citiess.AddOrUpdate(f => f.Id,
               new Entities.Cities
               {
                   Id = 6,
                   Name = "�����"
               });
            context.Citiess.AddOrUpdate(f => f.Id,
               new Entities.Cities
               {
                   Id = 7,
                   Name = "г���"
               });
            context.Citiess.AddOrUpdate(f => f.Id,
               new Entities.Cities
               {
                   Id = 8,
                   Name = "����"
               });
            context.Citiess.AddOrUpdate(f => f.Id,
               new Entities.Cities
               {
                   Id = 9,
                   Name = "��������"
               });
            context.Citiess.AddOrUpdate(f => f.Id,
               new Entities.Cities
               {
                   Id = 10,
                   Name = "�����-���������"
               });
            context.Citiess.AddOrUpdate(f => f.Id,
               new Entities.Cities
               {
                   Id = 11,
                   Name = "������ г�"
               });
            context.Citiess.AddOrUpdate(f => f.Id,
              new Entities.Cities
              {
                  Id = 12,
                  Name = "����"
              });
            context.Citiess.AddOrUpdate(f => f.Id,
              new Entities.Cities
              {
                  Id = 13,
                  Name = "�������"
              });
            context.Citiess.AddOrUpdate(f => f.Id,
              new Entities.Cities
              {
                  Id = 14,
                  Name = "�������"
              });
            #endregion
        }
    }
}
