using Acme.AppCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.AppCore.Interfaces
{
    public interface IActivity
    {
        Activity getActivityById(int Id);
        IList<Activity> getActivities();
    }
}
