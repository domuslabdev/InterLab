import { Data } from '@angular/router';

export class Lotti {
    LotId: number;
    Desc: string;
    DataAcquisizione: Date;
    DataCarico: Date;
    DataScadenza: Date;
    RichiesteTotali: Number;
    RichiesteAutoVal: Number;
    RichiesteVal: Number;
    DataInvioEsiti: Date;
    FDataRiscontroEsiti: Date;
    DataConfermaSgate: Date;
    Status: Number;
}

export class Lotto {
    LotId: number;
    Desc: string;
    DataCarico: Date;
    Dim: number;
    Status: Number;
    Esito: string;
}

export class User {
    id: number;
    name: string;
    cognome: string;
    professione: string;
    citta: string;
    statocivile: string;
    age: number;
    nascita: Date;
}

export class Registro {
    id: number;
    Lotto: number;
    Esito: string;
    date: Date;
}

export class tabledata {
    material: string;
    unity: string;
    quantity: number;
}

export class SgateRequest {
    TipoDomanda: string;
    SgateId: number;
    ReqTipoDoc: string;
    ReqScala: string;
    ReqNumeroDoc: string;
    ReqNome: string;
    ReqIstatComune: string;
    ReqInterno: string;
    ReqEnteRilsascioDoc: string;
    ReqEnteAreaCir: string;
    ReqEdificio: string;
    ReqDataDoc: Date;
    ReqCognome: string;
    ReqCivico: string;
    ReqCf: string;
    ReqCap: string;
    ProtRichiesta: number;
    ProtDomanda: number;
    LotId: number;
    IndTipoDoc: string;
    IndScala: string;
    IndNumeroDoc: string;
    IndNome: string;
    IndIstatComune: string;
    IndInterno: string;
    IndEnteRilDoc: string;
    IndEdificio: string;
    IndDataDoc: Date;
    IndCognome: string;
    IndCivico: string;
    IndCf: string;
    IndCap: string;
    IndAreaCirc: string;
    FruizioneCont: boolean;
    Forzato: boolean;
    EsitoS: string;
    EsitoD: string;
    DettaglioErrores: string;
    DataPresentazione: Date;
    DataPresaIncarico: Date;
    DataInvioEsitoD: Date;
    DataInizioAgev: Date;
    DataFineAgev: Date;
    DataDisponibilita: Date;
    DataChiusuras: Date;
    DataAmmissione: Date;
    DataAcquisizione: Date;
    CompFamigliaAnag: string;
    CodUtenteInd: string;
    CodUtenteCentr: string;
    CodErroreS: number;
    CentrScalae3: string;
    CentrScala2: string;
    CentrScala: string;
    CentrIstatComune3: string;
    CentrIstatComune2: string;
    CentrIstatComune: string;
    CentrInterno3: string;
    CentrInterno2: string;
    CentrInterno: string;
    CentrIban: string;
    CentrEdificioPlurifam: string;
    CentrEdificio3: string;
    CentrEdificio2: string;
    CentrEdificio: string;
    CentrDenCondominio: string;
    CentrCivico3: string;
    CentrCivico2: string;
    CentrCivico: string;
    CentrCap3: string;
    CentrCap2: string;
    CentrCap: string;
    CentrAreaCircolazione: string;
    CentrAreaCirc3: string;
    CentrAreaCir2: string;
    Allineamento: boolean;
}

export class Anagrafica
{
  codCliente:string;
codClienteIntegra:string;
ragioneSocialeCliente:string;
partitaIva:string;
codiceFiscale:string;
Comune:string;
Strada:string;
NumeroCivico:string;
CAP:string;
Provincia:string;
Nazione:string;
Email:string;
Telefono:string;
Fax:string;
DataInserimento:Date;
} 

export class Genere {
    id: number;
    nome: string;
}

export class Prodotto {
    id: number;
    nome: string;
    genere: number;
}


export class CapReq{
    Id:number;
    lotId:number;
    ProtRichiesta:string;
    TipoRichiesta:string;
    TipoUtente:number;
    DataPresentazione:Date;
    DataScadenzaInvioEsiti:Date;
    Nome:string;
    Cognome:string;
    Denominazione:string;
    Cf:string;
    Integra:string;
    IndFornitua:string;
    NumFamAnagrafica:number;
    Uso:string;
    StatoUtenza:number;
    EsitoAutoVal:string;
    EsitoManVal:string;
    Processato:number;
    ReqInterno:number;
    ImportoBi:number;
    ImportoIntegrativo:number;
    Esito:string;
    codCliente:string;
    codClienteNew:string;
    codClienteSuspect:number;
}


