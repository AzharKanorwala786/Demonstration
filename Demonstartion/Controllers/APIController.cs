using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Demonstartion.Models;

namespace Demonstartion.Controllers
{
    public class APIController : ApiController
    {
        [Route("api/API/AjaxMethod")]
        [HttpPost]
        public API AjaxMethod(API person)
        {
            person.DateTime = DateTime.Now.ToString();

            return person;
        }
    }
}
