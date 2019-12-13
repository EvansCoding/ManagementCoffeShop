namespace ManagementCoffeShop.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialize : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employe",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        userName = c.String(nullable: false, maxLength: 100),
                        password = c.String(nullable: false, maxLength: 100),
                        fullName = c.String(nullable: false, maxLength: 100),
                        sex = c.Boolean(nullable: false),
                        birthDay = c.DateTime(nullable: false),
                        address = c.String(nullable: false, maxLength: 500),
                        phoneNumber = c.String(nullable: false, maxLength: 11),
                        email = c.String(),
                        dayAtWork = c.DateTime(nullable: false),
                        statusOfWork = c.Boolean(nullable: false),
                        createDate = c.DateTime(nullable: false),
                        updateDate = c.DateTime(nullable: false),
                        Employe_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Office", t => t.Employe_Id)
                .Index(t => t.Employe_Id);
            
            CreateTable(
                "dbo.Office",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        nameOffice = c.String(),
                        createdDay = c.DateTime(nullable: false),
                        updatedDay = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employe", "Employe_Id", "dbo.Office");
            DropIndex("dbo.Employe", new[] { "Employe_Id" });
            DropTable("dbo.Office");
            DropTable("dbo.Employe");
        }
    }
}
