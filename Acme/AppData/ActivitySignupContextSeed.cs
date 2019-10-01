using Acme.AppCore.Entities;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acme.AppData
{
    public class ActivitySignupContextSeed
    {
        public static void Seed(ActivitySignupContext _db)
        {
            if (!_db.activities.Any())
            {
                // Adding Activities. 
                _db.activities.AddRange(getInitialActivities());
                _db.SaveChanges();
            }

        }

        static IEnumerable<Activity> getInitialActivities() {
            return new List<Activity>() {
                new Activity() { Name = "Activity 1", Details = "Activity 1 Details", RegistrationStartDT = new DateTime(2019,10,29), RegistrationEndDT = new DateTime(2019, 10, 31) },
                new Activity() { Name = "Activity 2", Details = "Activity 2 Details", RegistrationStartDT = new DateTime(2019,10,29), RegistrationEndDT = new DateTime(2019, 10, 31) },
                new Activity() { Name = "Activity 3", Details = "Activity 3 Details", RegistrationStartDT = new DateTime(2019,10,29), RegistrationEndDT = new DateTime(2019, 10, 31) },
                new Activity() { Name = "Activity 4", Details = "Activity 4 Details", RegistrationStartDT = new DateTime(2019,10,29), RegistrationEndDT = new DateTime(2019, 10, 31) },
                new Activity() { Name = "Activity 5", Details = "Activity 5 Details", RegistrationStartDT = new DateTime(2019,10,29), RegistrationEndDT = new DateTime(2019, 10, 31) },
            };
        }
    }
}
