namespace CourseWorkHelsiMSSQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddtblDoctors : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblDoctors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 250),
                        Surname = c.String(),
                        Spetialization = c.String(),
                        DateBirthday = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblDoctors");
        }
    }
}
