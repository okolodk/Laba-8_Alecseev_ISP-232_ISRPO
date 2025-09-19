using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_8_Alecseev_ISP_232_ISRPO
{
    internal class Car
    {
        private string Brand { get; set; }
        private string Model { get; set; }
        private int Year { get; set; }
        private int Mileage { get; set; }

        public Car(string brand, string model, int year, int mileage)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Mileage = mileage;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Бренд: {Brand}");
            Console.WriteLine($"Модель: {Model}");
            Console.WriteLine($"Год выпуска: {Year}");
            Console.WriteLine($"Пробег: {Mileage}");
            Console.WriteLine();

        }
    }
}
