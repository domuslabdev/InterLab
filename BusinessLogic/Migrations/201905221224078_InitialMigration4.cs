namespace BusinessLogic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.COM_ANAGRAFICA_TERZI",
                c => new
                    {
                        codCliente = c.String(nullable: false, maxLength: 128),
                        codClienteIntegra = c.String(),
                        ragioneSocialeCliente = c.String(),
                        partitaIva = c.String(),
                        codiceFiscale = c.String(),
                        Comune = c.String(),
                        Strada = c.String(),
                        NumeroCivico = c.String(),
                        CAP = c.String(),
                        Provincia = c.String(),
                        Nazione = c.String(),
                        Email = c.String(),
                        Telefono = c.String(),
                        Fax = c.String(),
                        DataInserimento = c.DateTime(),
                        DataNascita = c.DateTime(),
                    })
                .PrimaryKey(t => t.codCliente);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.COM_ANAGRAFICA_TERZI");
        }
    }
}
