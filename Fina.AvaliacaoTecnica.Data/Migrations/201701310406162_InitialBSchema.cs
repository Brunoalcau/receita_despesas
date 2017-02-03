namespace Fina.AvaliacaoTecnica.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialBSchema : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Businesses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Value = c.Single(nullable: false),
                        Category = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Observation = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Businesses");
        }
    }
}
