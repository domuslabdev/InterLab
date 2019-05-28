namespace BusinessLogic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.genere", "nome", c => c.String());
            DropColumn("dbo.magazzino", "prodotto");
            DropColumn("dbo.prodotto", "genere");
        }
        
        public override void Down()
        {
            AddColumn("dbo.prodotto", "genere", c => c.String());
            AddColumn("dbo.magazzino", "prodotto", c => c.String());
            AlterColumn("dbo.genere", "nome", c => c.Int(nullable: false));
        }
    }
}
