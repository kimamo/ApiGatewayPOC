using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace StockManagementApi.Controllers
{
    [Route("api/cardservice")]
    [ApiController]
    public class StockController : ControllerBase
    {
        // GET api/cards
        [HttpGet,Route("cards")]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "birthday", "christmas","thanksgiving", "graduation","anniversary","wedding","get well","condolense","thank you" };
        }
 
    }
}
