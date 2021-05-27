namespace DrugStoreManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class roles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        roleId = c.Int(nullable: false, identity: true),
                        roleName = c.String(),
                    })
                .PrimaryKey(t => t.roleId);
            
            AddColumn("dbo.Users", "roleId", c => c.Int(nullable: false));
            CreateIndex("dbo.Users", "roleId");
            AddForeignKey("dbo.Users", "roleId", "dbo.Roles", "roleId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "roleId", "dbo.Roles");
            DropIndex("dbo.Users", new[] { "roleId" });
            DropColumn("dbo.Users", "roleId");
            DropTable("dbo.Roles");
        }
    }
}
