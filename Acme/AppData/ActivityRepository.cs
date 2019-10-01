using Acme.AppCore.Entities;
using Acme.AppCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acme.AppData
{
    public class ActivityRepository : IActivity 
    {
        private ActivitySignupContext _db;
        public ActivityRepository(ActivitySignupContext dbContext)
        {
            _db = dbContext;
        }
        public Activity getActivityById(int Id)
        {
           return _db.activities.FirstOrDefault<Activity>(a => a.Id == Id);

        }
        public IList<Activity> getActivities()
        {
            return _db.activities.ToArray();
        }
    }
}
