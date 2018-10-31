using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assignment6MVC.Models;

namespace Assignment6MVC.Controllers
{
    public class ConverterController : Controller
    {
        public string Index(string type, string unitvalue)
        {
            return $"{type} and {unitvalue}";
        }
        public string FtoC(int C, int F)
        {

        }
        public string FtoK(int C, int F)
        {

        }
        public string CtoF(int C, int F)
        {

        }
        public string CtoK(int C, int F)
        {

        }
        public string KtoF(int C, int F)
        {

        }
        public string KtoC(int C, int F)
        {

        }

    }
}
