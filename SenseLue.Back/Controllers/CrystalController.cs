using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace SenseLue.Back.Controllers
{
    public class CrystalController : ApiController
    {
        [HttpGet]
        public object Insert(string id)
        {
            File.WriteAllText("E://WebSite/crystal.lueii.com/TXT/crystal.txt", id, Encoding.UTF8);
            return "Success";
        }

        [HttpGet]
        public object Get(string id)
        {
            return File.ReadAllText("E://WebSite/crystal.lueii.com/TXT/crystal.txt");
        }
    }
}
