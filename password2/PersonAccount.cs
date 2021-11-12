using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace password2
{
    public class PersonAccount 
    {
        // använd account som en lista? sen Person som accountname osv

        protected List<PersonAccount> AccountList = new List<PersonAccount>();

        protected string _accountName { get; set; }
        protected string _accountPin { get; set; }

        public PersonAccount this[int idx]
        {
            get
            {
                return AccountList[idx];
            }
        }

        public PersonAccount(string accountName, string accountPin)
        {
            _accountName = accountName;
            _accountPin = accountPin;
        }
        public PersonAccount()
        {
        }

        //call on generate account thru a created instance. If you make it static, call it thru the class name
        public PersonAccount GenerateAccount(string accountName, string accountPin)
        {
            return (new PersonAccount(accountName, accountPin));
        }
        public bool NameLogin(string userInput)
        {
            for (int i = 0; i < AccountList.Count; i++)
            {
                if (userInput == AccountList[i]._accountName)
                    return true;
            }
            return false;
        }
        public bool PassWordLogin(string userInput)
        {
            for (int i = 0; i < AccountList.Count; i++)
            {
                if (userInput == AccountList[i]._accountPin)
                    return true;
            }
            return false;
        }
    }
}
