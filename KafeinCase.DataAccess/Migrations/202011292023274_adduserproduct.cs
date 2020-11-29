namespace KafeinCase.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adduserproduct : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserProduct",
                c => new
                    {
                        UserProductId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserProductId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserProduct");
        }
    }
}
