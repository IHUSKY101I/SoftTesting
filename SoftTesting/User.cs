using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftTesting
{
    public class User
    {
        public const string DEFAULT_USERNAME = "Пользователь";
        public const string DEFAULT_PASSWORD = "Password";
        public const string DEFAULT_LAST_RESULT = "0/0(0%)";

        private string name = DEFAULT_USERNAME;
        private string password = DEFAULT_PASSWORD;
        private string lastResult = DEFAULT_LAST_RESULT;

        public User(string name, string password, string lastResult)
        {
            this.name = name;
            this.password = password;
            this.lastResult = lastResult;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }
        public string LastResult
        {
            get
            {
                return lastResult;
            }

            set
            {
                lastResult = value;
            }
        }
    }
}
