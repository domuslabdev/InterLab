//using GruppoCap.Core;
//using GruppoCap.DAL;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using GestioneRimborsi.Core.Models;

//namespace GestioneRimborsi.Core
//{
//    public class BonusIdricoRepo : RepositoryBase<Lotto>, IBonusIdricoRepo
//    {

//        public IEnumerable<BICapLotto> GetCapLotti(int? id)
//        {
//            List<BICapLotto> nodi;
//            IList<BICapLotto> data = new List<BICapLotto>();
//            BICapLotto nodo = null;

//            //using (var db = new PetaPoco.Database("test.application.db"))
//            //{
//            try
//            {
//                if (id == null)
//                {
//                    data = db.Query<BICapLotto>("select * from GRI_BI_LOTS_CAP ").ToList();
//                    nodi = data.ToList();
//                }
//                else
//                {
//                    nodo = db.FirstOrDefault<BICapLotto>(string.Format("select * from GRI_BI_LOTS_CAP l where l.BI_CAP_ID={0}", id));
//                    // nodi = data.ToList();
//                    data.Add(nodo);
//                    //  data.ToList().Add(new [T]nodo);
//                    //      data.Concat(new BICapLotto[] { new BICapLotto(nodo) });

//                    //       IEnumerable<T> items = new T[] { new T("msg") };
//                }
//            }
//            catch (System.Data.SqlClient.SqlException e)
//            {
//                throw (new InvalidOperationException(e.Message));
//            }


//            return data.OrderBy(x => x.Id);
//        }

//        public void InsertCapLotto(BICapLotto Lotto)
//        {
//            try
//            {
//                db.Insert(Lotto);
//            }
//            catch (Exception e)
//            {
//                throw;
//            }
//        }

//        public void InsertCapReq(BICapRequest Lotto)
//        {
//            try
//            {
//                db.Insert(Lotto);
//            }
//            catch (Exception ex)
//            {
//                throw;
//            }
//        }

//        public void InsertSgateReq(SgateRichieste req)
//        {
//            try
//            {
//                db.Insert(req);
//            }
//            catch (Exception)
//            {
//                throw;
//            }
//        }

//        public void UpdateSgateReq(string table, string pk, SgateRichieste nodo)
//        {
//            try
//            {
//                db.Update(table, pk, nodo);
//            }
//            catch (Exception)
//            {
//                throw;
//            }
//        }

//        public void UpdateCapLotto(string table, string pk, BICapLotto nodo)
//        {
//            try
//            {
//                db.Update(table, pk, nodo);
//            }
//            catch (Exception e)
//            {
//                throw;
//            }
//        }

//        public IEnumerable<SgateRichieste> GetSgateReqS(int? id, string sql = null)
//        {

//            IEnumerable<SgateRichieste> data = null;
//            //using (var db = new PetaPoco.Database("test.application.db"))
//            //{
//            try
//            {
//                if (id == null && sql == null)
//                    data = db.Query<SgateRichieste>("select * from gri_bi_request r join gri_bi_lots_cap l on r.BI_LOTCAP_ID = l.BI_CAP_ID ");
//                else if (id != null)
//                    data = db.Query<SgateRichieste>(string.Format("select * from gri_bi_request r where r.BI_LOTCAP_ID ={0}", id));
//                else if (sql != null)
//                    data = db.Query<SgateRichieste>(string.Format(sql));

//            }
//            catch (System.Data.SqlClient.SqlException e)
//            {
//                throw (new InvalidOperationException(e.Message));
//            }

//            return data;
//        }

//        public List<BICapRequest> GetReqS(int id)
//        {
//            List<BICapRequest> data = null;
//            //using (var db = new PetaPoco.Database("test.application.db"))
//            //{
//            try
//            {
//                data = db.Query<BICapRequest>(string.Format("select * from gri_bi_request_cap r where r.bi_lotcap_id={0}", id)).ToList();
//            }
//            catch (System.Data.SqlClient.SqlException e)
//            {
//                throw (new InvalidOperationException(e.Message));
//            }
//            return data;
//        }

//        public BICLienti GetCliente(string sql)
//        {
//            BICLienti data;
//            try
//            {
//                data = db.FirstOrDefault<BICLienti>(sql);
//            }
//            catch (System.Data.SqlClient.SqlException e)
//            {
//                throw (new InvalidOperationException(e.Message));
//            }
//            return data;
//        }

//        public void DeleteCapReq(int lotto)
//        {
//            db.Delete<BICapRequest>("BI_LOTCAP_ID", lotto);
//        }

//        public BICapRequest GetCapReq(int id)
//        {
//            return db.Single<BICapRequest>(id);
//        }

//        public List<BICapRequest> GetCapReqS(int id)
//        {
//            List<BICapRequest> data = null;
//            //using (var db = new PetaPoco.Database("test.application.db"))
//            //{
//            try
//            {
//                data = db.Query<BICapRequest>(string.Format("select * from gri_bi_request_cap r where r.bi_lotcap_id={0}", id)).ToList();
//            }
//            catch (System.Data.SqlClient.SqlException e)
//            {
//                throw (new InvalidOperationException(e.Message));
//            }
//            return data;
//        }

//        //oldversion
//        //public List<BICapRequest> GetCapReqS(int id)
//        //{
//        //    return db.Query<BICapRequest>("BI_LOTCAP_ID", id).ToList();
//        //}

//        public void UpdateCapReq(string table, string pk, BICapRequest nodo)
//        {
//            try
//            {
//                db.Update(table, pk, nodo);
//            }
//            catch (Exception e)
//            {
//                throw;
//            }
//        }

//        public string GetContratto(string sql)
//        {
//            string res;
//            try
//            {
//                res = db.FirstOrDefault<string>(sql);
//            }
//            catch (Exception e)
//            {
//                throw;
//            }
//            return res;
//        }

//        public BIPuf GetPuf(string sql)
//        {
//            BIPuf res;
//            try
//            {
//                res = db.FirstOrDefault<BIPuf>(sql);
//            }
//            catch (Exception e)
//            {
//                throw;
//            }
//            return res;
//        }

//        public T GetPufGeneric<T>(T sql) where T : IEntity
//        {
//            T res;
//            try
//            {
//                res = db.FirstOrDefault<T>(sql.ToString());
//            }
//            catch (Exception e)
//            {
//                throw;
//            }
//            return res;
//        }

//        public T CapReqByID<T>(int id) where T : IEntity
//        {
//            try
//            {
//                return db.SingleOrDefault<T>(id);
//            }
//            catch (Exception e)
//            {
//                throw;
//            }
//        }

//        public SgateRichieste SgateByID(int id)
//        {
//            try
//            {
//                return db.SingleOrDefault<SgateRichieste>(id);
//            }
//            catch (Exception e)
//            {
//                throw;
//            }
//        }

//        public BICapLotto LottoByID(int id)
//        {
//            try
//            {
//                return db.SingleOrDefault<BICapLotto>(id);
//            }
//            catch (Exception e)
//            {
//                throw;
//            }
//        }

//        public BIComAnagrafica IntegraByCodCLiente(string cliente)
//        {
//            var data = db.FirstOrDefault<BIComAnagrafica>(string.Format("select * from GRI_DATI_VALIDAZIONE_BI_V where COD_CLIENTE='{0}'", cliente));
//            return data;
//        }

//        public List<BIContratto> GetContrattoByCliente(string sql)
//        {
//            return db.Query<BIContratto>(sql).ToList();
//        }

//        public IUpdateOperationResult CalcoloBonusIdrico(int lotId)
//        {
//            try
//            {
//                db.OpenSharedConnection();
//                try
//                {
//                    var Param = new List<PetaPocoParameter>();
//                    Param.Add(new PetaPocoInputParameter("P_LOT_ID", System.Data.DbType.Int32, lotId));
//                    var result = this.db.ExecuteProcedure("GRI_CREATE_WATER_BONUS_P", Param.ToArray());

//                    return new UpdateOperationResult(result.Result);
//                }
//                finally
//                {
//                    db.CloseSharedConnection();
//                }

//            }
//            catch (Exception ex)
//            {
//                return new UpdateOperationResult(false, ex.Message);
//            }
//        }

//        public List<BICapRequest> getLotDetails(QueryOptions options)
//        {
//            List<BICapRequest> result = null;

//            try
//            {
//                string databaseQuery = string.Format("select * from GRI_BI_GETLOTDETAILS_V where row_number between {0} and {1} AND {2}", options.getLowerBound(),
//                    options.getUpperBound(),
//                    string.Join(" AND ", options.ConditionCriterias.Select(ee => string.Format(ee.Key.matchingVerb, ee.Key.fieldName, ee.Value)))
//                    );

//                result = db.Query<BICapRequest>(databaseQuery).ToList();
//            }
//            catch (System.Data.SqlClient.SqlException e)
//            {
//                throw (new InvalidOperationException(e.Message));
//            }
//            return result;
//        }
//    }
//}
