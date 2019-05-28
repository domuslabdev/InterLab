using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using forAngular.Models;
using System.Web.Http.Cors;
using BusinessLogic.Crud;
using Repo.Entity;
using System.Web.Http;
using Repo.Entity;

namespace forAngular.Controllers
{

    public class HomeController : Controller
    {
      
        [EnableCors(origins: "http://localhost:4200/", headers: "*", methods: "*")]
        [System.Web.Http.HttpPost]
        public JsonResult setLotti(Lotti lotto)
        {
            if (lotto.Desc == null)
                return Json("ko", JsonRequestBehavior.AllowGet);

            Insert.InsertLotti(lotto);

            return Json("ok", JsonRequestBehavior.AllowGet);
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")] // tune to your needs
        public JsonResult ValidateReqs(List<CapReq> reqs)
        {
            if(reqs==null)
           return     Json("KO", JsonRequestBehavior.AllowGet);
            Insert.InsertCapReqs(reqs);
            return Json("ok", JsonRequestBehavior.AllowGet);
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")] // tune to your needs
        public JsonResult InsertSgate(string lottoname)
        {
            if(lottoname==null)
               return Json("duplcaite", JsonRequestBehavior.AllowGet);

            BusinessLogic.Process.XmlConvert.UploadXml(string.Format("{0}", lottoname));

            var model = Get.getLotti();
            return Json("ok", JsonRequestBehavior.AllowGet);
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")] // tune to your needs
        public JsonResult getLotti(string text)
        {
            if(text!="OK" && text!=null)
                BusinessLogic.Process.XmlConvert.UploadXml(string.Format("{0}", text));

            var model =Get.getLotti();
            return Json(model, JsonRequestBehavior.AllowGet);
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")] // tune to your needs
        public JsonResult getSgateReqs(int lotid=0)
        {
         //   var lotid = int.Parse(slotid);
            if (lotid==null || lotid==0)
                return Json("KO", JsonRequestBehavior.AllowGet);

            var model = Get.getSgateReqs(lotid);
            return Json(model, JsonRequestBehavior.AllowGet);
        }

      public ActionResult getAnagrafica(string text)
        {
            var model = Get.getAnagrafica();
            return Json(model, JsonRequestBehavior.AllowGet);
        }

    }
}