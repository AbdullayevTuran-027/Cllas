using System;
using System.Collections.Generic;
using System.Text;

namespace car_task
{
    internal class Car : Vehicle
    {
        public string Brand;
        public string Model;
        public int FuelCapaCity;
        public int FuelFor1Km;
        public int CurrentFuel;
        public void ShowInfo()
        {
            Console.WriteLine($"Brand:{Brand}|Model:{Model}|FuelCapacity:{FuelCapaCity}|FuelFor1Km:{FuelFor1Km}|CurrentFuel:{CurrentFuel}|Color:{Color}|Year:{Year}");
        }

        public void Drive(double Distance)
        {

            if (CurrentFuel < Distance * FuelFor1Km)
            {
                Console.WriteLine("Benzin vurmaq lazimdi");
            }
            else
            {
                Console.WriteLine("Ged eve");
            }
        }
    }
}