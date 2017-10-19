using SenseLue.Application;
using SenseLue.Domain.Entity;
using SenseLue.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SenseLue.Web.Controllers
{
    public class MinWordController : Controller
    {
        MinWordApp minWordApp = new MinWordApp();
        UserApp user = new UserApp();
        // GET: MinWord
        public ActionResult Index()
        {
            var minWordEntityList = minWordApp.GetList().OrderBy(a => a.F_CreatorTime);
            var minWordList = new List<MinWordViewModel>();

            List<int> DateRecordList = new List<int>();

            foreach (var minWordEntity in minWordEntityList)
            {
                if (!DateRecordList.Contains(minWordEntity.F_CreatorTime.Value.Year))
                {
                    DateRecordList.Add(minWordEntity.F_CreatorTime.Value.Year);
                }
            }
            
            for (int i = 0; i < DateRecordList.Count; i++)
            {
                MinWordViewModel minWord = new MinWordViewModel();
                //minWord.TimeMinorList = new List<MinWordViewModel.TimeMinor>();
                //foreach (var minWordEntity in minWordEntityList)
                //{
                    
                //    if (DateRecordList[i] == minWordEntity.F_CreatorTime.Value.Year)
                //    {
                        
                //        minWord.DateGroup = minWordEntity.F_CreatorTime.Value.Year;
                //        MinWordViewModel.TimeMinor timeViewModel = new MinWordViewModel.TimeMinor();
                //        timeViewModel.F_AuthorId = minWordEntity.F_CreatorUserId;
                //        timeViewModel.F_Title = minWordEntity.F_Title;
                //        timeViewModel.F_AuthorName = string.IsNullOrEmpty(minWordEntity.F_CreatorUserId) ? "无名" : user.GetForm(minWordEntity.F_CreatorUserId).F_PenName;
                //        timeViewModel.F_CreateTime = minWordEntity.F_CreatorTime;
                //        timeViewModel.F_Id = minWordEntity.F_Id;
                //        timeViewModel.F_Content = minWordEntity.F_Content;
                //        minWord.TimeMinorList.Add(timeViewModel);
                //    }
                //}
                minWordList.Add(minWord);
            }

            ViewBag.MinWords = minWordList;
            return View();
        }
    }
}