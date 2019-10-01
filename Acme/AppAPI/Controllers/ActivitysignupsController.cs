using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Acme.AppCore.Entities;
using Acme.AppCore.Interfaces;
using Acme.AppData;
using Microsoft.AspNetCore.Mvc;

namespace Acme.AppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivitysignupsController : ControllerBase
    {
        private readonly ISignups _signup;
        public ActivitysignupsController(ISignups signups)
        {
            _signup = signups;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }       

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Signups Signup)
        {
            _signup.Save(Signup);
        }

      
    }
}
