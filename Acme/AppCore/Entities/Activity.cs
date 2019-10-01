using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.AppCore.Entities
{
    public class Activity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public DateTime RegistrationStartDT { get; set; }
        public DateTime RegistrationEndDT { get; set; }
    }
}
