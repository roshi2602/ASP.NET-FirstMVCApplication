using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
 
namespace FirstMVCApplication.Models
{
    public class Employeedemo               //model containing data
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public string Ecity { get; set; }
    }

    public class EmployeeAddress
    {
        public int Aid { get; set; }
        public string City { get; set; }
        public int PinCode { get; set; }
    }
}