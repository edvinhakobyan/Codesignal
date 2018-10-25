using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runners_Meetings
{
    class Program
    {
        static void Main(string[] args)
        {

            runnersMeetings(new int[] { 1, 4, 2 },new int[] { 27, 18, 24 });
        }



        static int runnersMeetings(int[] stPoint, int[] speed)
        {
            int count = 0;
            for (double t = 0; t < 1000; t+=0.001)
            {
                double[] currentPosition = new double[stPoint.Length];
                for (int i = 0; i < stPoint.Length; i++)
                    currentPosition[i] += Math.Round((stPoint[i] + t * speed[i]), 2);

                for (int j = 0; j < currentPosition.Length; j++)
                {
                    int mm = currentPosition.Count(a => a == currentPosition[j]);
                    if (mm > count) count = mm;
                }
            }
            return count;
        }

            static int runnersMeetings1(int[] stP, int[] s)
        {
            int mult = 1;
            for (int i = 0; i < s.Length; mult *= s[i], i++) ;

            int min = stP.Min();
            for (int i = 0; i < stP.Length; i++)
            {
                if(min>=0)
                  stP[i] -= Math.Abs(min);
                else
                    stP[i] += Math.Abs(min);
            }

            int[] arrBool = new int[10*mult];

            while (true)
            {
                for (int i = 0; i < stP.Length; i++)
                {
                    for (int j = stP[i]; j < stP[i] + s[i]; j++)
                        arrBool[j]++;
                    stP[i] = stP[i] + s[i];
                }
            }


            for (int i = 0; i < arrBool.Length; i++)
            {
                if (arrBool[i] > 1)
                {
                    Console.WriteLine(i);
                    break;
                }
            }

            







                return 1;
        }
    }
}
