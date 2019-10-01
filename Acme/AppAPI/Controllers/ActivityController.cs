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
    public class ActivityController : ControllerBase
    {
        private readonly IActivity _activity;

        public ActivityController(IActivity activity)
        {
            _activity = activity;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IList<Activity>> Get()
        {
            return _activity.getActivities().ToList<Activity>();
        }


        // POST api/values
        [HttpPost]
        public void Post([FromBody] Activity activity)
        {
            // TODO: Add Admin functionality to add New Activities            
        }
       
    }
}
