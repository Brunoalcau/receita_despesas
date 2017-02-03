namespace Fina.AvaliacaoTecnica.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialBSchema1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Businesses", "Date", c => c.DateTime(nullable: false, precision: 0));
            AlterColumn("dbo.Businesses", "Observation", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Businesses", "Observation", c => c.String());
            AlterColumn("dbo.Businesses", "Date", c => c.DateTime(nullable: false));
        }
    }
}
