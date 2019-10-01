using Acme.AppCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.UniteTests
{
    public class SignupBuilder
    {
        private Signups _signup;
        public string FirstName => "Ricky";
        public string LastName => "Patel";
        public string Email => "rpatel@live.ca";
        public string Phone => "289-700-8457";
        public int ActivityId => 1007;

        public Signups Build()
        {
            return _signup;
        }

        public Signups WithDefaultValues()
        {
            _signup = new Signups();
            _signup.FirstName = this.FirstName;
            _signup.LastName = this.LastName;
            _signup.Email = this.Email;
            _signup.Phone = this.Phone;
            _signup.ActivityId = this.ActivityId;

            return _signup;
        }
        
    }
}
