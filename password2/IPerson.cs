using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace password2
{
    interface IPerson
    {
        /// <summary>
        /// 
        /// </summary>
        public string _accountName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string _accountPin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public PersonAccount this[int index] => null;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountName"></param>
        /// <param name="accountPin"></param>
        /// <returns></returns>
        public PersonAccount GenerateAccount(string accountName, int accountPin);

    }
}
