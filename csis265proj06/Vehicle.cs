using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csis265proj06
{
    public class Vehicle
    {
        private string make;
        private string model;
        private double gallonsInTank;
        private int ignitionOn;


        #region CONSTRUCTORS
        public Vehicle()
        {
            make = string.Empty;
            model = string.Empty;
            gallonsInTank = 0.0;
            ignitionOn = 0;
        }        public Vehicle(string inputMake, string inputModel, double inputGallons, int inputIgnition)
        {
            make = inputMake;
            model = inputModel;
            gallonsInTank = inputGallons;
            ignitionOn = inputIgnition;
        }


        #endregion

        #region SETTERS
        public void SetMake(string inputMake)
        {
            make = inputMake;
        }
        public void SetModel(string inputModel)
        {
            model = inputModel;
        }
        public void SetGallons(double inputGallons)
        {
            gallonsInTank = inputGallons;
        }
        public void SetIgnition(int inputIgnition)
        {
            ignitionOn = inputIgnition;
        }
        #endregion


        #region GETTERS
        public string GetMake()
        {
            return make;
        }
        public string GetModel( )
        {
            return model;
        }
        public double GetGallons( )
        {
            return gallonsInTank;
        }
        public int GetIgnition( )
        {
            return ignitionOn;
        }
        #endregion

        public void Travel()
        {
            if (gallonsInTank > 0 && ignitionOn == 1)
            {
                System.Console.WriteLine($"Car is traveling with {gallonsInTank} gallons.");
            }
            else
            {
                System.Console.WriteLine($"Car cannot travel!!! Ignition: {ignitionOn} Gallons: {gallonsInTank}");
            }
        }

        public void DisplayVehicleState()
        {
            System.Console.WriteLine($"\nVehicle make: {make}");
            System.Console.WriteLine($"Vehicle model: {model}");
            System.Console.WriteLine($"Vehicle ignition: {ignitionOn}");
            System.Console.WriteLine($"Vehicle has: {gallonsInTank} gallons");
        }
    }
}
