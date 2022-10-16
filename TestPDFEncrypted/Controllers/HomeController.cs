using PDFEncrypter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestPDFEncrypted.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file, string nom)
        {
            string s = CustomHelpers.Save(file, nom, "abcd", @"C:\\Users\\dell\\Desktop\\LIB", "csharpTest");
            CustomHelpers.Generate("abcd", s, @"C:\\Users\\dell\\Desktop\\LIB");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}