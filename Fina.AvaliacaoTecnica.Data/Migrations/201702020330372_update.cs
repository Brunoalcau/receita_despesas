namespace Fina.AvaliacaoTecnica.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Businesses", "Type", c => c.Int(nullable: false));
            AlterColumn("dbo.Businesses", "Category", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Businesses", "Category", c => c.Int(nullable: false));
            DropColumn("dbo.Businesses", "Type");
        }
    }
}
