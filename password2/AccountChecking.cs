using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace password2
{
    public class AccountChecking : PersonAccount
    {

        public void Add(PersonAccount person)
        {
            AccountList.Add(person);
        }
        public void Sort()
        {
            AccountList.Sort();
        }
        public int Count(AccountChecking account)
        {
            return AccountList.Count;
        }

        public bool NameIsValid(string accountName)
        {
            if (accountName.Length < 6) return false;
            if (accountName.Length > 15) return false;
            if (!HasUppercase(accountName)) return false;
            if (!HasLowercase(accountName)) return false;
            if (HasDigits(accountName)) return false;
            if (Contains(accountName, '/')) return false;
            if (Contains(accountName, '&')) return false;
            if (Contains(accountName, '.')) return false;
            if (Contains(accountName, ',')) return false;
            if (Contains(accountName, '<')) return false;
            if (Contains(accountName, '>')) return false;
            if (Contains(accountName, '|')) return false;
            if (Contains(accountName, '´')) return false;
            if (Contains(accountName, '*')) return false;
            if (Contains(accountName, '#')) return false;
            if (int.TryParse(accountName, out _) == true) return false;
            if (string.IsNullOrEmpty(accountName) || string.IsNullOrWhiteSpace(accountName)) return false;
            return true;
        }
        public bool PassWordIsValid(string accountPin)
        {
            if (accountPin.Length < 6) return false;
            if (accountPin.Length > 15) return false;
            if (!HasUppercase(accountPin)) return false;
            if (!HasLowercase(accountPin)) return false;
            if (Contains(accountPin, '/')) return false;
            if (Contains(accountPin, '&')) return false;
            if (Contains(accountPin, '.')) return false;
            if (Contains(accountPin, ',')) return false;
            if (Contains(accountPin, '<')) return false;
            if (Contains(accountPin, '>')) return false;
            if (Contains(accountPin, '|')) return false;
            if (Contains(accountPin, '´')) return false;
            if (Contains(accountPin, '*')) return false;
            if (Contains(accountPin, '#')) return false;
            if (string.IsNullOrEmpty(accountPin) || string.IsNullOrWhiteSpace(accountPin)) return false;

            return true;
        }
        private bool Contains(string accountdetails, char letter)
        {
            foreach (char character in accountdetails)
                if (character == letter) return true;

            return false;
        }
        private bool HasUppercase(string accountdetails)
        {
            foreach (char letter in accountdetails)
                if (char.IsUpper(letter)) return true;

            return false;
        }
        private bool HasLowercase(string accountdetails)
        {
            foreach (char letter in accountdetails)
                if (char.IsLower(letter)) return true;

            return false;
        }
        private bool HasDigits(string accountdetails)
        {
            foreach (char letter in accountdetails)
                if (char.IsDigit(letter)) return true;

            return false;
        }
    }
}
