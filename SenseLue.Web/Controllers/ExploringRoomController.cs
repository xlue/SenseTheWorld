using SenseLue.Code.Algorithm;
using SenseLue.Code.Image;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SenseLue.Web.Controllers
{
    public class ExploringRoomController : Controller
    {
        // GET: ExploringRoom
        public ActionResult Index()
        {
            return View();
        }

        

        public ActionResult CopyWorld()
        {
            //ImageHelpr.CreateFontImage("MMZT.ttf", "请选择文字类别", true, 120);
            return View();
        }

        public ActionResult FontImage(string number, string text)
        {
            string fileName = string.Empty;
            if (number == "F18" || number == "F69" || number == "F67" || number == "F65" || number == "F64" || number == "F63" || number == "F62" || number == "F61")
                fileName = ImageHelpr.CreateFontImage(number + ".otf", text, true, 120) + ".png";
            else
                fileName = ImageHelpr.CreateFontImage(number + ".ttf", text, true, 120) + ".png";

            return Json(new { fileName = fileName, message = "success" }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult WebCrawl()
        {

            return View();
        }


        public ActionResult leaveWord()
        {
            return View();
        }


        public ActionResult FavoritesMusic()
        {
            return View();
        }
    }
}