using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FirstMVCApplication.Models;
namespace FirstMVCApplication.ViewModel
{
    public class EmpDetail
    {
        public Employeedemo ED { get; set; }
        public EmployeeAddress EA { get; set; }
        public string PageTitle { get; set; }
        public string PageHeader { get; set; }
    }
}