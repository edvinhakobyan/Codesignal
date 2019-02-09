using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace reverseInParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = "((012(3456)789)(hghgh))";
            reverseInParentheses(t);
        }


        static string reverseInParentheses(string inputString)
        {
            string pattern =@"[(]{1}[0-9()a-z]{0,}[)]{1}";
            MatchCollection m = Regex.Matches(inputString, pattern);

            foreach(Match mm in m)
            {
                foreach(Group mmm in mm.Groups)
                {
                    Console.WriteLine(mmm);
                }
            }

            
            return null;
        }


        public static void substringReverse(ref string a, int start, int end)
        {
              a =   a.Substring(0, start) +
                new string(a.Substring(start + 1, end - start - 1).Reverse().ToArray()) +
                 a.Substring(end+1, a.Length - end-1);
        }



    }
}
