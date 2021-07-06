using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;         //for view result
using FirstMVCApplication.ViewModel;
using FirstMVCApplication.Models;

namespace FirstMVCApplication.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Details()
        {
            //create EmployeeDemo object
            Employeedemo ed = new Employeedemo()
            {
                //hardcoding data here
                Eid = 2,
                Ename = "sakshi",
                Ecity = "mumbai"
            };
            //address object
            EmployeeAddress ea = new EmployeeAddress()
            {
                Aid = 100,
                City = "pune",
                PinCode = 452012
            };
            //     return ed;
            //create View Model object
            EmpDetail empd = new EmpDetail()
            {
                EA = ea,
                ED = ed,
                PageTitle = "Employee Detail page",
                PageHeader = "Employee"
            };

            //now passing the EmpDetail model to view
            return View(empd);

        }

    }
            
        }
    
