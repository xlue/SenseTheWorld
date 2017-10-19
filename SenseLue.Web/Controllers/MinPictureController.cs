using log4net;
using SenseLue.Application;
using SenseLue.Code;
using SenseLue.Data.DBContext;
using SenseLue.Domain.Entity;
using SenseLue.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SenseLue.Web.Controllers
{
    public class MinPictureController : Controller
    {
        log4net.ILog log = LogFactory.GetLogger("ReflectionLayout");
        MinWordApp minWordApp = new MinWordApp();
        // GET: MinPicture
        public ActionResult Index()
        {
            string ip = Net.Ip;
            log.Info(ip + "," + Net.GetLocation(ip) + "," + DateTime.Now.ToString() + "\r\n");
            return View();
        }

        public ActionResult Detail(string id)
        {
            MinWordViewModel minWord = new MinWordViewModel();
            var minWordEntity = minWordApp.GetForm(id);
            minWord.F_Id = minWordEntity.F_Id;
            minWord.F_Cover = minWordEntity.F_Cover;
            minWord.F_Content = minWordEntity.F_Content;
            minWord.F_Title = minWordEntity.F_Title;
            minWord.F_AuthorId = minWordEntity.F_CreatorUserId;
            minWord.F_AuthorName = "剪凡";
            minWord.F_Date = Common.DateStringFromNow(minWordEntity.F_CreatorTime);
            minWord.F_CreateTime = minWordEntity.F_CreatorTime;
            return View(minWord);
        }
    }
}