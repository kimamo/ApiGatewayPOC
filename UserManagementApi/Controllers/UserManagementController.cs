using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UserManagementApi.Controllers
{
    [Route("api/userservice")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET api/users
        [HttpGet,Route("users")]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Mwende", "Kimamo","Zayla","Zahra","Makena" };
        }
 
    }
}
