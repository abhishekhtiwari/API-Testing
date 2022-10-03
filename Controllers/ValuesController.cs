using API_Testing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_Testing.Controllers
{
    public class ValuesController : ApiController
    {
        //GET api/values/5
        //    or
        //GET api/values? id = 5
        [HttpGet]
        public string Get(int id)
        {
            return id.ToString();
        }

        //Post api/values?id=5.1
        [HttpPost]
        public string Get(double id)
        {
            return id.ToString();
        }

        //Note:
        //------------------- Model as a Parameter ---------------------
        //1. GET => [FromUri]
        //2. POST => [FromBody]


        // api/values?Username=abhishek&password=123    
        //                or 
        //PostMan: Body-> x-www-form-urlencoded
        [HttpGet]     
        public string Getuser([FromUri] Authenticate authenticate)
        {
            return authenticate.Username.ToString();
        }

        // api/values?Username=abhishek&password=123  
        [HttpPost]
        public string GetInfo([FromBody] Authenticate authenticate)
        {
            return authenticate.Username.ToString();
        }

        // PUT api/values/5
        [HttpPut]
        public void GetIdjhd(int id, [FromUri] Authenticate authenticate)
        {
        }
       
    }
}
