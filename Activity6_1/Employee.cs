using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activity6_1
{
    class Employee
    {
        private int _empID;
        private string _loginName;
        //private string _password;
        private int _securityLevel;
        
        public int EmployeeID
        {
            get { return _empID; }
        }
        public string LoginName
        {
            get { return _loginName; }
            set { _loginName = value; }
        }
        public string Password
        {
            get;
            set;
        }
        public int SecurityLevel
        {
            get { return _securityLevel; }
        }

        public void Login(string loginName, string password)
        {
            LoginName = loginName;
            Password = password;
            //Data normally retrieved from database.
            //Hard coded for demo only.
            if (loginName == "Smith" & password == "js")
            {
                _empID = 1;
                _securityLevel = 2;
            }
            else if (loginName == "Jones" & password == "mj")
            {
                _empID = 2;
                _securityLevel = 4;
            }
            else
            {
                throw new Exception("login incorrect.");
            }
        }

    }
}
