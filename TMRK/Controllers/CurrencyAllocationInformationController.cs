using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMRK.Business;
using TMRK.DTOModel;

namespace TMRK.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CurrencyAllocationInformationController : Controller
    {
        private ICAI _CAI;
        private bool IsAuth = false;
        public CurrencyAllocationInformationController(ICAI CAI)
        {
            _CAI = CAI;
        }

        [HttpGet]
        public string GetCurrencyAllocationInformati(CAIInput input)
        {
            return "AA" + input.BankAuthorityNo;
        }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (Request.Headers["Auth"] == @"123e4567-e89b-12d3-a456-426655440000")
            {
                IsAuth = true;
            } 
        }
        [Route("Get")]
        [HttpPost]
        public ActionResult GetCurrencyAllocationInformation([FromBody] CAIInput input)
        {
            if (!IsAuth)
            {
                return Unauthorized();
            }
            var value = _CAI.GetCurrencyAllocationInformation(input);
            return Ok(value);
        }
    }
}
