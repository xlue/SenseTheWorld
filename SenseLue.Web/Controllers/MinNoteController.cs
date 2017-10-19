using SenseLue.Application;
using SenseLue.Code;
using SenseLue.Domain.Entity;
using SenseLue.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SenseLue.Web.Controllers
{
    public class MinNoteController : Controller
    {
        SenseRecordApp senseRecordApp = new SenseRecordApp();
        UserApp user = new UserApp();
        // GET: MinNote
        public ActionResult Index()
        {
            var senseRecordEntityList = senseRecordApp.GetList();
            var minNoteList = new List<MinNoteViewModel>();

            foreach (var senseRecordEntity in senseRecordEntityList)
            {
                MinNoteViewModel minNote = new MinNoteViewModel();
                minNote.F_AuthorId = senseRecordEntity.F_CreatorUserId;

                minNote.F_AuthorName = string.IsNullOrEmpty(senseRecordEntity.F_CreatorUserId) ? "无名": user.GetForm(senseRecordEntity.F_CreatorUserId).F_PenName;
                minNote.F_Date = Common.DateStringFromNow(senseRecordEntity.F_CreatorTime);
                minNote.F_CreateTime = senseRecordEntity.F_CreatorTime;
                minNote.F_Id = senseRecordEntity.F_Id;
                minNote.F_Descripition = senseRecordEntity.F_Description;
                minNote.F_MindMapFilePath = senseRecordEntity.F_MindMapFilePath;
                minNote.F_MindMapImagePath = senseRecordEntity.F_MindMapImagePath;
                minNote.F_Title = senseRecordEntity.F_Title;
                minNote.F_SenseWord = senseRecordEntity.F_SenseWord;
                minNote.F_SenseLabel = new List<string>();
                string label = senseRecordEntity.F_Label;
                if(label.IndexOf(",") > -1)
                {
                    string[] labelArray = label.Split(',');
                    for (int i = 0; i < labelArray.Length; i++)
                    {
                        minNote.F_SenseLabel.Add(Enum.GetName(typeof(Common.SenseLabel), int.Parse(labelArray[i])));
                    }
                }
                else
                {
                    minNote.F_SenseLabel.Add(Enum.GetName(typeof(Common.SenseLabel), int.Parse(label)));
                }


                minNoteList.Add(minNote);
            }
            ViewBag.MinNotes = minNoteList.OrderByDescending(a => a.F_CreateTime).ToList<MinNoteViewModel>();

            return View();
        }

        // GET: MinNote
        public ActionResult ViewNote(string id)
        {
            MinNoteViewModel minNote = new MinNoteViewModel();
            var senseRecordEntity = senseRecordApp.GetForm(id);
            minNote.F_Id = senseRecordEntity.F_Id;
            minNote.F_MindMapFilePath = senseRecordEntity.F_MindMapFilePath;
            minNote.F_MindMapImagePath = senseRecordEntity.F_MindMapImagePath;
            minNote.F_SenseWord = senseRecordEntity.F_SenseWord;
            minNote.F_Title = senseRecordEntity.F_Title;
            minNote.F_AuthorId = senseRecordEntity.F_CreatorUserId;
            minNote.F_AuthorName = string.IsNullOrEmpty(senseRecordEntity.F_CreatorUserId) ? "无名" : user.GetForm(senseRecordEntity.F_CreatorUserId).F_PenName;
            minNote.F_Date = Common.DateStringFromNow(senseRecordEntity.F_CreatorTime);
            minNote.F_CreateTime = senseRecordEntity.F_CreatorTime;
            return View(minNote);
        }


    }
}