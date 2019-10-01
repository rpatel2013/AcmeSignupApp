using Acme.AppCore.Entities;
using Acme.AppCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.AppData
{
    public class SignupRepository : ISignups 
    {
        private ActivitySignupContext _db;
        private readonly IActivity _activity;

        public SignupRepository(ActivitySignupContext dbContext, IActivity activity) { 
            _db = dbContext;
            _activity = activity;
        }

        public void Save(Signups signup) {

            var activity = _activity.getActivityById(signup.ActivityId);
            signup.Activity = activity;
            signup.Comment = signup.Comment == null ? "" : signup.Comment;

            _db.signups.Add(signup);
            _db.SaveChanges();
        }
    }
}
