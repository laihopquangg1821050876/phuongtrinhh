namespace phuongtrinhb1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128, unicode: false),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Username);
            
            CreateTable(
                "dbo.khachhangs",
                c => new
                    {
                        username = c.String(nullable: false, maxLength: 128),
                        address = c.String(),
                    })
                .PrimaryKey(t => t.username);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        StudentID = c.String(nullable: false, maxLength: 128, unicode: false),
                        Studentname = c.String(),
                    })
                .PrimaryKey(t => t.StudentID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Student");
            DropTable("dbo.khachhangs");
            DropTable("dbo.Accounts");
        }
    }
}
