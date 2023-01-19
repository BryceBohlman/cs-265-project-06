using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csis265proj06
{
    public class KeyboardUtility
    {
        public static int GetValidInteger(string message)
        {
            int value = 0;
            System.Console.Write(message);
            value = Convert.ToInt32(System.Console.ReadLine());

            return value;
        }
        public static double GetValidDouble(string message)
        {
            double value = 0;
            System.Console.Write(message);
            value = Convert.ToDouble(System.Console.ReadLine());

            return value;
        }

        public static string GetValidString(string message)
        {
            string value = string.Empty;
            System.Console.Write(message);
            int length = 0;

            do
            {
                value = System.Console.ReadLine();
                length = value.Trim().Length;

                if (length == 0)
                {
                    System.Console.WriteLine("Please enter a valid string");
                }
            } while (length == 0);

            return value;
        }
    }
}
