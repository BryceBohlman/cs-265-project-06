using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csis265proj06
{
    public class Program
    {
        public static void Main()
        {
            Vehicle myCar = new Vehicle();
            int answer = 0;

            do
            {
                myCar.SetMake(KeyboardUtility.GetValidString("\nEnter the make of the vehicle: "));
                myCar.SetModel(KeyboardUtility.GetValidString("Enter the model of the vehicle: "));
                myCar.SetIgnition(KeyboardUtility.GetValidInteger("Enter if the ignition is on (0=NO/1=YES): "));
                myCar.SetGallons(KeyboardUtility.GetValidDouble("Enter the # of gallons in the vehicle: "));

                myCar.DisplayVehicleState();
                myCar.Travel();

                answer = KeyboardUtility.GetValidInteger("\nContinue the program (0=NO/1=YES) ? ");
            } while (answer == 1);

            

            System.Console.ReadLine();
        }
    }
}
