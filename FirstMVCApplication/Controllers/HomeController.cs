using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMVCApplication.Models;
namespace FirstMVCApplication.Controllers
{
    public class HomeController : Controller       //home is name of controller
    {
       
        public ActionResult Index()                                   //action method
        {
            Employeedemo ed = new Employeedemo()
            {
                Eid = 1,
                Ename = "roshi",
                Ecity = "pune"
            };
            ViewData["Employeedemo"] = ed;
            ViewData["hh"] = "Employee details";
         

            return View(ed);
            //now goto index.cs and perform coding there
            //@(razor syntax) is used in Index.cshtml to mix HTML and server side code using C#
            //url for this-https://localhost:44325/Home/Index/5
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