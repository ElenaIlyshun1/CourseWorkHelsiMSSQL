namespace CourseWorkHelsiMSSQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddtblCitiesNames : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblCitiesNames",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 250),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblCitiesNames");
        }
    }
}
