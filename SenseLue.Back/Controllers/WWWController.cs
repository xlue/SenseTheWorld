using SenseLue.Application;
using SenseLue.Code;
using SenseLue.Domain.Entity;
using SenseLue.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SenseLue.Back.Controllers
{
    [HandlerLogin]
    public class WWWController : Controller
    {
        SenseRecordApp senseRecordApp = new SenseRecordApp();
        UserApp user = new UserApp();
        // GET: WWW
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MinWorld()
        {
            return View();
        }

        public ActionResult MinNote()
        {
            var senseRecordEntityList = senseRecordApp.GetList();
            var minNoteList = new List<MinNoteViewModel>();

            foreach (var senseRecordEntity in senseRecordEntityList)
            {
                MinNoteViewModel minNote = new MinNoteViewModel();
                minNote.F_AuthorId = senseRecordEntity.F_CreatorUserId;

                minNote.F_AuthorName = string.IsNullOrEmpty(senseRecordEntity.F_CreatorUserId) ? "无名" : user.GetForm(senseRecordEntity.F_CreatorUserId).F_PenName;
                minNote.F_Date =Common.DateStringFromNow(senseRecordEntity.F_CreatorTime);
                minNote.F_Id = senseRecordEntity.F_Id;
                minNote.F_Descripition = senseRecordEntity.F_Description;
                minNote.F_MindMapFilePath = senseRecordEntity.F_MindMapFilePath;
                minNote.F_MindMapImagePath = senseRecordEntity.F_MindMapImagePath;
                minNote.F_Title = senseRecordEntity.F_Title;
                minNote.F_SenseWord = senseRecordEntity.F_SenseWord;
                minNote.F_CreateTime = senseRecordEntity.F_CreatorTime;
                minNoteList.Add(minNote);
            }

            ViewBag.MinNotes = minNoteList;
            ViewBag.SenseLabel = EnumHelper.EnumToNamesList<Common.SenseLabel>();

            return View();
        }

        [HttpPost]
        public ActionResult GetNote()
        {
            string id = Request.Form["id"].ToString();
            var senseRecord =  senseRecordApp.GetForm(id);
            return Json(senseRecord);

        }


        [HttpPost]
        [ValidateInput(false)]
        public ActionResult OperationArticle()
        {
            string id = Request.Form["aId"].ToString();
            string type = Request.Form["aType"].ToString();
            string title = Request.Form["aTitle"].ToString();
            string content = Request.Form["aContent"].ToString();
            string Descripition = string.Empty;
            string SensnLabel = string.Empty;
            if (Request.Form["aDescripition"] != null)
                Descripition = Request.Form["aDescripition"].ToString();
            if (Request.Form["aLabel"] != null)
                SensnLabel = Request.Form["aLabel"].ToString();
            if (type == "MinNote")
            {
                if(id.Trim() == "0")
                {
                    SenseRecordEntity senseRecordEntity = new SenseRecordEntity();
                    senseRecordEntity.F_SenseWord = content;
                    senseRecordEntity.F_Description = Descripition;
                    senseRecordEntity.F_SortCode = 1;
                    senseRecordEntity.F_DeleteMark = false;
                    senseRecordEntity.F_Title = title;
                    senseRecordEntity.F_Label = SensnLabel.TrimEnd(',');
                    senseRecordApp.SubmitForm(senseRecordEntity, senseRecordEntity.F_Id);
                }
                else
                {
                    SenseRecordEntity senseRecordEntity = new SenseRecordEntity();
                    senseRecordEntity.F_Id = id;
                    senseRecordEntity.F_SenseWord = content;
                    senseRecordEntity.F_Description = Descripition;
                    senseRecordEntity.F_SortCode = 1;
                    senseRecordEntity.F_DeleteMark = false;
                    senseRecordEntity.F_Title = title;
                    senseRecordEntity.F_Label = SensnLabel.TrimEnd(',');
                    senseRecordApp.SubmitForm(senseRecordEntity, id);
                }


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