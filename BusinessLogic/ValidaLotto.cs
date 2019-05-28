//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BusinessLogic
//{

//    public enum stato { acq = 1, inelab, elab, inval, val, approvato };
//    public enum esito { KO = 0, OK, KO1, KO2, OK2, KO3, KO4, KO5, KO6, OK6, KO7, INTEGRA, STRESS };

//    public class ValidaLotto
//    {
//        static int countautoval = -1;


//        public IEnumerable<BICapLotto> GetLotto(string file = null)
//        {
//            //if(file!=null)
//            //    Xml2Struct.UploadXml(bi);s
//            Validazione.UpLoadLotto(bi);
//            return bi.GetCapLotti(null);
//        }

//        public void InsertLotto(BICapLotto lotto)
//        {
//            bi.InsertCapLotto(lotto);
//        }

//        public IEnumerable<SgateRichieste> GetRichieste(int id)
//        {
//            return bi.GetSgateReqS(id);
//        }

//        public List<BICapRequest> GetCapReqS(int id)
//        {
//            return bi.GetCapReqS(id);
//        }

//        public IEnumerable<BICapLotto> ValidaLotto(int lotto, List<int> reqId = null)
//        {
//            int validate = 0;
//            int autoval = 0;
//            BIEsito err = null;
//            var nodo = bi.GetCapLotti(lotto).FirstOrDefault();
//            BICapRequest res;
//            var nodi = bi.GetSgateReqS(lotto);
//            var oldautoval = nodo.RichiesteAutoVal;
//            string stress = "";

//            foreach (var item in nodi)
//            {
//                //VALIDAZIONE PER UTENTI INDIVIDUALI
//                if (item.CodUtenteInd != null)
//                {
//                    if (item.EsitoD == esito.OK.ToString())
//                    {
//                        continue;
//                    }

//                    var temp = item.EsitoD;
//                    var id = item.Id;

//                    try
//                    {
//                        if (reqId.Contains(item.Id))
//                        {
//                            item.EsitoD = esito.OK.ToString();
//                            stress = '-' + esito.STRESS.ToString();
//                            ++validate;
//                        }
//                        else
//                            throw new Exception();
//                    }
//                    catch (Exception e)
//                    {
//                        err = Validazione.CheckReqInd(item, bi);

//                        item.EsitoD = err.error >= 6 ? esito.KO1.ToString() :
//                                     Validazione.CheckEsito(err, ref validate, ref autoval);
//                        item.EsitoS = err.esito;
//                        oldautoval = nodo.Status == 1 ? autoval : nodo.RichiesteAutoVal;
//                    }

//                    if (nodo.Status == 3)
//                    {
//                        autoval = nodo.RichiesteAutoVal;
//                        res = bi.GetCapReq(item.Id);
//                        res.EsitoManVal = item.EsitoD;
//                        res.Esito = item.EsitoD + stress;
//                        bi.UpdateCapReq("GRI_BI_REQUEST_CAP", "BI_REQ_CAP_ID", res);
//                    }
//                    else
//                    {
//                        var capReq = new BICapRequest();
//                        capReq.codCliente = err.cliente != null ? err.cliente : "ND";
//                        capReq.Cognome = item.IndCognome;
//                        capReq.Nome = item.IndNome;
//                        capReq.Integra = item.CodUtenteInd;
//                        capReq.lotId = lotto;
//                        capReq.EsitoAutoVal = item.EsitoD;
//                        capReq.Esito = err.esito;
//                        capReq.Id = item.Id;
//                        capReq.TipoUtente = 1;
//                        bi.InsertCapReq(capReq);
//                    }

//                    bi.UpdateSgateReq("GRI_BI_REQUEST", "BI_REQ_ID", item);
//                }

//                //VALIDAZIONE PER UTENTI CENTRALIZZATI
//                else if (item.CodUtenteCentr != null)
//                {
//                    if (item.EsitoD != esito.KO.ToString() && item.EsitoD != null)
//                    {
//                        validate += item.EsitoD != esito.OK.ToString() ? 1 : 0;
//                        continue;
//                    }

//                    var temp = item.EsitoD;

//                    try
//                    {
//                        if (reqId.Contains(item.Id))
//                        {
//                            item.EsitoD = esito.OK.ToString();
//                            stress = '-' + esito.STRESS.ToString();
//                            ++validate;
//                        }
//                        else
//                            throw new Exception();
//                    }
//                    catch (Exception e)
//                    {
//                        err = Validazione.CheckReqCentr(item, bi);

//                        item.EsitoD = err.error >= 4 ? (esito.KO1).ToString() : err.error == 99 ? esito.KO2.ToString() :
//                                     Validazione.CheckEsitoCentr(err, ref validate, ref autoval);

//                        oldautoval = nodo.Status == 1 ? autoval : nodo.RichiesteAutoVal;
//                    }

//                    if (nodo.Status == 3)
//                    {
//                        autoval = nodo.RichiesteAutoVal;
//                        res = bi.GetCapReq(item.Id);
//                        res.EsitoManVal = item.EsitoD;
//                        res.Esito = res.Esito + stress;
//                        bi.UpdateCapReq("GRI_BI_REQUEST_CAP", "BI_REQ_CAP_ID", res);
//                    }
//                    else
//                    {
//                        var capReq = new BICapRequest();
//                        capReq.codCliente = err.cliente;
//                        capReq.Denominazione = item.CentrDenCondominio;
//                        capReq.Integra = item.CodUtenteCentr;
//                        capReq.lotId = lotto;
//                        capReq.EsitoAutoVal = item.EsitoD;
//                        capReq.Esito = err.esito;
//                        capReq.Id = item.Id;
//                        capReq.TipoUtente = 0;
//                        bi.InsertCapReq(capReq);
//                    }

//                    bi.UpdateSgateReq("GRI_BI_REQUEST", "BI_REQ_ID", item);
//                }
//                else
//                    continue;
//            }

//            nodo.Status = validate < nodi.Count() ? (int)stato.elab : (int)stato.val;
//            nodo.RichiesteTotali = nodi.Count();
//            nodo.RichiesteAutoVal = oldautoval;
//            nodo.RichiesteVal = validate;
//            bi.UpdateCapLotto("GRI_BI_LOTS_CAP", "BI_CAP_ID", nodo);
//            return bi.GetCapLotti(null);
//        }

//        public SgateRichieste GetCliente(string cf, int id)
//        {
//            //return bi.GetCliente(string.Format("select * from com_anagrafica_terzi where COD_CLIENTE='{0}'", cf));
//            return bi.SgateByID(id);
//        }

//        public void SetIntegra(int id, string integra, List<string> lscode)
//        {
//            int validate = 0;
//            int autoval = 0;
//            BIEsito err = null;

//            var nodo = bi.SgateByID(id);

//            var lotto = bi.LottoByID(nodo.lotCapId);
//            var status = lscode.Where(x => x.Contains("OK")).Count();
//            lotto.RichiesteVal += status == 0 ? 0 : 1;

//            lotto.Status = lotto.RichiesteVal == lotto.RichiesteTotali ? 5 : lotto.Status;
//            if (nodo.CodUtenteInd != null)
//                nodo.CodUtenteInd = integra;
//            else
//                nodo.CodUtenteCentr = integra;
//            //          return;
//            nodo.EsitoD = lscode.Count() == 0 ? nodo.EsitoD : string.Join(",", lscode.ToArray());

//            bi.UpdateSgateReq("GRI_BI_REQUEST", "BI_REQ_ID", nodo);
//            bi.UpdateCapLotto("GRI_BI_LOTS_CAP", "BI_CAP_ID", lotto);

//        }

//        public List<BIContratto> GetUtenze(string cliente)
//        {
//            var res = bi.IntegraByCodCLiente(cliente);
//            var nodi = bi.GetContrattoByCliente(string.Format(@"select * from GRI_DATI_VALIDAZIONE_BI_V where COD_CODICE_FISCALE='{0}'", res.codiceFiscale));

//            return nodi;
//        }


//        public BIContratto GetUtenza(string utenza)
//        {
//            var nodi = bi.GetContrattoByCliente(string.Format(@"select * from GRI_DATI_VALIDAZIONE_BI_V where COD_CLIENTE_INTEGRA='{0}'", utenza)).First();
//            return nodi;
//        }
//    }
//}


