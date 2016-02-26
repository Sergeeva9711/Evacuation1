namespace Evacuation.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ProjectID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DataCreation = c.DateTime(nullable: false),
                        DataStrart = c.DateTime(nullable: false),
                        DataEnd = c.DateTime(nullable: false),
                        User_UserID = c.Int(),
                    })
                .PrimaryKey(t => t.ProjectID)
                .ForeignKey("dbo.Users", t => t.User_UserID)
                .Index(t => t.User_UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Projects", "User_UserID", "dbo.Users");
            DropIndex("dbo.Projects", new[] { "User_UserID" });
            DropTable("dbo.Projects");
        }
    }
}
