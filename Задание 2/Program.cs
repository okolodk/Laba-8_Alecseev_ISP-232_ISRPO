using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_8_Alecseev_ISP_232_ISRPO.Задание_2
{
    public struct Point2D
    {
        public int x;
        public int y;

        public Point2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public double DistanceTo(Point2D other)
        {
            int other_x = other.x;
            int other_y = other.y;
            return Math.Sqrt(Math.Pow(other_x - this.x, 2) + Math.Pow(other_y - this.y, 2));
        }
    }

    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Point2D t1 = new Point2D(10, 0);
        //    Point2D t2 = new Point2D(25, 0);
        //    Console.WriteLine(t1.DistanceTo(t2));
        //}
    }
}
