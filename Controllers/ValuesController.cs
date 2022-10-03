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

        // POST api/values      
        [HttpGet]     
        public string Get1(Authenticate authenticate)
        {
            return authenticate.ToString();
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }
       
    }
}
