namespace consultants.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Assignment",
                c => new
                    {
                        Assignment_ID = c.Int(nullable: false, identity: true),
                        Assignment_Name = c.String(),
                        Client_Name = c.String(),
                        Percentage = c.String(),
                        Start_Date = c.DateTime(nullable: false),
                        End_Date = c.DateTime(nullable: false),
                        Comment = c.String(),
                        Consultant_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Assignment_ID)
                .ForeignKey("dbo.Consultant", t => t.Consultant_ID, cascadeDelete: true)
                .Index(t => t.Consultant_ID);
            
            CreateTable(
                "dbo.Consultant",
                c => new
                    {
                        Consultant_ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Consultant_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Assignment", "Consultant_ID", "dbo.Consultant");
            DropIndex("dbo.Assignment", new[] { "Consultant_ID" });
            DropTable("dbo.Consultant");
            DropTable("dbo.Assignment");
        }
    }
}
