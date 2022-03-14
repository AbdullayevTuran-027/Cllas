using System;

namespace car_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Brand = "BMW";
            car1.Model = "M5";
            car1.FuelCapaCity = 80;
            car1.FuelFor1Km = 2;
            car1.CurrentFuel = 50;
            car1.Color = "black";
            car1.Year = 2016;

            car1.ShowInfo();
            car1.Drive(45);
        }
    }
}