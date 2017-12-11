namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ff1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("don", "id", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
        }
    }
}
