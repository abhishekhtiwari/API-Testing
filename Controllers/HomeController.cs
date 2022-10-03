using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace API_Testing.Controllers
{
    public class HomeController : Controller
    {        
        // Home/Index
        [HttpGet]
        public string Index()
        {
            return "abhishek";
        }

        //home/index?id=5&name=abhishek          
        [HttpPost]
        public string Index(int id,string name)
        {
            return id.ToString()+" "+name;
        }
    }
}
