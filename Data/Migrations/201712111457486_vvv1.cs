namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class vvv1 : DbMigration
    {
        public override void Up()
        {
            DropTable("don");
        }
        
        public override void Down()
        {
        }
    }
}
