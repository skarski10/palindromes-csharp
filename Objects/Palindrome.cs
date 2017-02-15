using System;
using System.Collections.Generic;
using System.IO;

namespace PalindromesApp.Objects
{
    public class Palindromes
    {
        private string _userString;
        private string _reverseString;

        public Palindromes(string newUserString)
        {
            _userString = newUserString;
        }

        public void SetReverseString()
        {
            string backwards = "";
            for (int i = _userString.Length; i > 0; i--)
            {
                backwards += _userString[i-1];
            }
            Console.WriteLine(backwards);
            _reverseString = backwards;
        }

        public bool CompareStrings()
        {
            return _userString == _reverseString;
        }

        public string GetUserString()
        {
            return _userString;
        }
        public string GetReverseString()
        {
            return _reverseString;
        }
    }
}
