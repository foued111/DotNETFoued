namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v7 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "don",
                c => new
                {
                    DonId = c.Int(nullable: false),
                    dateDon = c.DateTime(nullable: false, precision: 0),
                    Name = c.String(maxLength: 255, storeType: "nvarchar"),
                    Type = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                    picture = c.Double(nullable: false),


                })
                .PrimaryKey(t => t.DonId);
                
        }
        
        public override void Down()
        {
            
        }
    }
}
