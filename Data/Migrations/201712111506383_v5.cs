namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
              "volunteering.don",
              c => new
              {
                  DonId = c.Int(nullable: false),
                  dateDon = c.DateTime(nullable: false, precision: 0),
                  Name = c.String(maxLength: 255, storeType: "nvarchar"),
                  Type = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                  picture = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),


                  id = c.Int(),
              })
              .PrimaryKey(t => t.DonId)
              .ForeignKey("volunteering.user", t => t.id)
              .Index(t => t.id);

        }
        
        public override void Down()
        {
        }
    }
}
