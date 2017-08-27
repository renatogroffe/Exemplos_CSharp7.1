using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ExemploAsyncMain.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { ".NET Core 2.0", ".NET Standard 2.0", "ASP.NET Core 2.0" };
        }
    }
}