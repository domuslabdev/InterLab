namespace BusinessLogic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CapRichieste",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        lotId = c.Int(nullable: false),
                        ProtRichiesta = c.String(),
                        TipoRichiesta = c.String(),
                        TipoUtente = c.Int(nullable: false),
                        DataPresentazione = c.DateTime(nullable: false),
                        DataScadenzaInvioEsiti = c.DateTime(nullable: false),
                        Nome = c.String(),
                        Cognome = c.String(),
                        Denominazione = c.String(),
                        Cf = c.String(),
                        Integra = c.String(),
                        IndFornitua = c.String(),
                        NumFamAnagrafica = c.Int(nullable: false),
                        Uso = c.String(),
                        StatoUtenza = c.Int(nullable: false),
                        EsitoAutoVal = c.String(),
                        EsitoManVal = c.String(),
                        Processato = c.Int(nullable: false),
                        ReqInterno = c.Int(nullable: false),
                        ImportoBi = c.Double(nullable: false),
                        ImportoIntegrativo = c.Double(nullable: false),
                        Esito = c.String(),
                        codCliente = c.String(),
                        codClienteNew = c.String(),
                        codClienteSuspect = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CapRichieste");
        }
    }
}
