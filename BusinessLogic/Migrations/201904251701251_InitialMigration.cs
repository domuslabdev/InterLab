namespace BusinessLogic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Caplotti",
                c => new
                    {
                        LotId = c.Int(nullable: false, identity: true),
                        Desc = c.String(),
                        DataAcquisizione = c.DateTime(),
                        DataCarico = c.DateTime(),
                        DataScadenza = c.DateTime(),
                        RichiesteTotali = c.Int(nullable: false),
                        RichiesteAutoVal = c.Int(nullable: false),
                        RichiesteVal = c.Int(nullable: false),
                        DataInvioEsiti = c.DateTime(),
                        FDataRiscontroEsiti = c.DateTime(),
                        DataConfermaSgate = c.DateTime(),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LotId);
            
            CreateTable(
                "dbo.Lotti",
                c => new
                    {
                        LotId = c.Int(nullable: false, identity: true),
                        Desc = c.String(nullable: false, maxLength: 128),
                        Status = c.Int(nullable: false),
                        Esito = c.String(),
                        Dim = c.Int(nullable: false),
                        DataCarico = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.LotId);
            
            CreateTable(
                "dbo.SgateRichieste",
                c => new
                    {
                        SgateId = c.Int(nullable: false, identity: true),
                        LotId = c.Int(nullable: false),
                        ProtDomanda = c.Int(nullable: false),
                        ProtRichiesta = c.Int(nullable: false),
                        TipoDomanda = c.String(),
                        ReqNome = c.String(),
                        ReqCognome = c.String(),
                        ReqCf = c.String(),
                        ReqTipoDoc = c.String(),
                        ReqNumeroDoc = c.String(),
                        ReqDataDoc = c.DateTime(),
                        ReqEnteRilsascioDoc = c.String(),
                        ReqIstatComune = c.String(),
                        ReqEnteAreaCir = c.String(),
                        ReqCivico = c.String(),
                        ReqEdificio = c.String(),
                        ReqScala = c.String(),
                        ReqInterno = c.String(),
                        ReqCap = c.String(),
                        CodUtenteInd = c.String(),
                        IndNome = c.String(),
                        IndCognome = c.String(),
                        IndCf = c.String(),
                        IndTipoDoc = c.String(),
                        IndNumeroDoc = c.String(),
                        IndDataDoc = c.DateTime(),
                        IndEnteRilDoc = c.String(),
                        IndIstatComune = c.String(),
                        IndAreaCirc = c.String(),
                        IndCivico = c.String(),
                        IndEdificio = c.String(),
                        IndScala = c.String(),
                        IndInterno = c.String(),
                        IndCap = c.String(),
                        CodUtenteCentr = c.String(),
                        CentrIban = c.String(),
                        CentrDenCondominio = c.String(),
                        CentrEdificioPlurifam = c.String(),
                        CentrIstatComune = c.String(),
                        CentrAreaCircolazione = c.String(),
                        CentrCivico = c.String(),
                        CentrEdificio = c.String(),
                        CentrScala = c.String(),
                        CentrInterno = c.String(),
                        CentrCap = c.String(),
                        CentrIstatComune2 = c.String(),
                        CentrAreaCir2 = c.String(),
                        CentrCivico2 = c.String(),
                        CentrEdificio2 = c.String(),
                        CentrScala2 = c.String(),
                        CentrInterno2 = c.String(),
                        CentrCap2 = c.String(),
                        CentrIstatComune3 = c.String(),
                        CentrAreaCirc3 = c.String(),
                        CentrCivico3 = c.String(),
                        CentrEdificio3 = c.String(),
                        CentrScalae3 = c.String(),
                        CentrInterno3 = c.String(),
                        CentrCap3 = c.String(),
                        CompFamigliaAnag = c.String(),
                        DataDisponibilita = c.DateTime(),
                        DataAmmissione = c.DateTime(),
                        DataPresentazione = c.DateTime(),
                        DataInizioAgev = c.DateTime(),
                        DataFineAgev = c.DateTime(),
                        Allineamento = c.Boolean(nullable: false),
                        FruizioneCont = c.Boolean(nullable: false),
                        DataAcquisizione = c.DateTime(),
                        DataPresaIncarico = c.DateTime(),
                        Forzato = c.Boolean(nullable: false),
                        EsitoD = c.String(),
                        DataInvioEsitoD = c.DateTime(),
                        EsitoS = c.String(),
                        CodErroreS = c.Int(nullable: false),
                        DettaglioErrores = c.String(),
                        DataChiusuras = c.DateTime(),
                    })
                .PrimaryKey(t => t.SgateId);
            
            CreateTable(
                "dbo.Richieste",
                c => new
                    {
                        LotId = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 128),
                        Cognome = c.String(nullable: false, maxLength: 128),
                        Status = c.Int(nullable: false),
                        Esito = c.String(nullable: false),
                        Tipo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.LotId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Richieste");
            DropTable("dbo.SgateRichieste");
            DropTable("dbo.Lotti");
            DropTable("dbo.Caplotti");
        }
    }
}
