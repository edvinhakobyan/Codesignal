using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = checkPalindrome("aaaabbybbaaaa");
        }

        public static bool checkPalindrome(string inputString)
        {
            return inputString == new string(inputString.Reverse().ToArray());
        }
    }
}
