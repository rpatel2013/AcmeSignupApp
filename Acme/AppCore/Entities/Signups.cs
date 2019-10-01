using Acme.AppCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.AppCore.Entities
{
    public class Signups
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Comment { get; set; }
        public int ActivityId { get; set; }
        public Activity Activity { get; set; }
        
    }
}
