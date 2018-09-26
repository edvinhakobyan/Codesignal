using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace centuryFromYear
{
    class Program
    {
        static void Main(string[] args)
        {
            centuryFromYear(1988);
        }

        public static int centuryFromYear(int year)
        {
            return year % 100 == 0 ? year / 100 : year / 100 + 1;
        }
    }
}
