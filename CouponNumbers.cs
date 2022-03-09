using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class CouponNumbers
    {
        ///<summary>
        /// UC1- Generating random coupon codes.
        ///</summary>
        public static void GenerateCouponNumber()
        {
            var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var chars = new char[8];
            Random random = new Random();
            for (int i = 0; i < chars.Length ; i++)
            {
                chars[i]=characters[random.Next(characters.Length)];
            }
            var finalCode = new string(chars);
            
            Console.WriteLine(finalCode);                                                                                                  
        }
    }
}