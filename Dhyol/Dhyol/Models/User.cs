using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dhyol.Models
{
    
    public class User
    {
        public int ID { get; }
        public string Name { get; set; }
        public string Email { get; private set; }
        public string Kind { get; set; }
        private string _password;

        public string Password
        {
            get { return _password; }
            private set { _password = value; }
        }



    }
}