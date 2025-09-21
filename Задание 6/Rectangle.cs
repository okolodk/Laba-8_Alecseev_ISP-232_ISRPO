using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_8_Alecseev_ISP_232_ISRPO.Задание_6
{
    internal class Rectangle
    {
        private double width; 
        private double height;

        public double Width 
        {
            get { return width; }
            set 
            {
                if (value <= 0) { this.width = 1; }
                else { this.width = value; }
            }
        }
        public double Height
        {
            get { return height; }
            set
            {
                if (value <= 0) { this.height = 1; }
                else { this.height= value; }
            }
        }

        public double Area { get { return width * height; } }
        public Rectangle()
        {
            this.width = 1;
            this.height = 1;
        }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Ширина: {width}. Высота: {height}. Площадь: {Area}.");
        }

    }
}
