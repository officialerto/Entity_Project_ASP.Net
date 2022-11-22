using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Skill_CodeFirstEntity.Models.Class;

namespace Skill_CodeFirstEntity.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {  //FARKLI SINIFTAN METOT TÜRETİLECEKSE O SINIFA AİT NESNE TÜRETİLİR(C ADINDA)
            CONTEXT c = new CONTEXT();
            var degerler = c.YETENEKLERS.ToList(); 
            return View(degerler);
        }
    }
}