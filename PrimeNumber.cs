using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PrimeNumber
    {
        ///<summary>
        /// UC1- Prime Number or not.
        ///</summary>
        public static void CheckPrimeNumber()
        {
            int num;
            int flag = 0;

            Console.WriteLine("Enter the Number ");

            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("NUmber is not Prime.");
                    flag = 1;
                    break;
                }
                else
                {
                    Console.WriteLine("NUmber is Prime");
                }
            }
        }
    }
}