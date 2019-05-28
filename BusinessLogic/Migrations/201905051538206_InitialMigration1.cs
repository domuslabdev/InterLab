namespace BusinessLogic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.bolla",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        num = c.Int(nullable: false),
                        fornitore = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.fattura",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        num = c.Int(nullable: false),
                        CLiente = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.fornitori",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.genere",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.magazzino",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        quantita = c.Int(nullable: false),
                        prodotto = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.prodotto",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(),
                        genere = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.prodotto");
            DropTable("dbo.magazzino");
            DropTable("dbo.genere");
            DropTable("dbo.fornitori");
            DropTable("dbo.fattura");
            DropTable("dbo.bolla");
        }
    }
}
