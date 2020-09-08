using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TMRK.Controllers
{
    [ApiController]
    [Route("Index")]
    public class IndexController : Controller
    {
        public string Index()
        {
            return "Service Is UP";
        }
    }
}