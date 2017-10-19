using SenseLue.Application;
using SenseLue.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SenseLue.Web.Controllers
{
    [HandlerLogin]
    public class EditorWorldController : Controller
    {
        // GET: EditorWorld
        public ActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //[ValidateInput(false)]
        public ActionResult OperationArticle()
        {
            string type = Request.Form["aType"].ToString();
            string title = Request.Form["aTitle"].ToString();
            string Descripition = string.Empty;
            string content = Request.Form["aContent"].ToString();
            if (Request.Form["aDescripition"] != null)
                Descripition = Request.Form["aDescripition"].ToString();

            if(type == "minNote")
            {
                SenseRecordApp senseRecord = new SenseRecordApp();
                SenseRecordEntity senseRecordEntity = new SenseRecordEntity();
                senseRecordEntity.F_SenseWord = content;
                senseRecordEntity.F_Description = Descripition;
                senseRecordEntity.F_SortCode = 1;
                senseRecordEntity.F_DeleteMark = false;
                senseRecordEntity.F_Title = title;
                senseRecord.SubmitForm(senseRecordEntity, senseRecordEntity.F_Id);
            }
            else
            {
                MinWordApp minWord = new MinWordApp();
                MinWordEntity minWordEnttiy = new MinWordEntity();
                minWordEnttiy.F_Title = title;
                minWordEnttiy.F_Content = content;
                minWordEnttiy.F_SortCode = 1;
                minWordEnttiy.F_DeleteMark = false; 
                minWord.SubmitForm(minWordEnttiy, minWordEnttiy.F_Id);
            }

            
            return Content("ok");
        }
    }
}