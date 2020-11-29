namespace KafeinCase.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateusersmodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "UsersImageUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "UsersImageUrl");
        }
    }
}
