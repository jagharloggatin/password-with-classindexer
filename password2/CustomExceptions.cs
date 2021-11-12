using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace password2
{
    class CustomExceptions : Exception
    {
    }
    public class TooManyDigits 
    {
        public TooManyDigits(string userInput)
        {

        }
    }

}
