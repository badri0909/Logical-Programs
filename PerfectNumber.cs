using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PerfectNumber
    {
        ///<summary>
        /// UC1- Finding Perfect numbers with a range.
        ///</summary>
        public static void FindPerfectNumber()
        {
            int i, n, sum;
            int minNum, maxNum;

            Console.WriteLine("Input the startting range of number");
            minNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the end Range NUmber");
            maxNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The perfect numbers within the range : ");
            for (n = minNum; n <= maxNum; n++)
            {
                i = 1;
                sum = 0;

                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == n)
                    Console.Write(" {0} ", n);
            }
        }
    }
}