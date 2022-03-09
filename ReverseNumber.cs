using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class ReverseNumber
    {
        ///<summary>
        /// UC1- Reversing numbers.
        ///</summary>
        public static void ReverseTheNumber()
        {
            int n, reverse = 0, rem;

            Console.WriteLine("Enter long numbers");
            n=Convert.ToInt32(Console.ReadLine());

            while (n != 0)
            {
                rem = n % 10;
                reverse=reverse*10+rem;
                n /= 10;
            }
            Console.WriteLine("Reversed numbers " + reverse);
        }
    }
}