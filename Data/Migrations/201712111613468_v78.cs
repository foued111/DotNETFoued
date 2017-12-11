namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v78 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Dons", name: "user_id", newName: "id");
            RenameIndex(table: "dbo.Dons", name: "IX_user_id", newName: "IX_id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Dons", name: "IX_id", newName: "IX_user_id");
            RenameColumn(table: "dbo.Dons", name: "id", newName: "user_id");
        }
    }
}
