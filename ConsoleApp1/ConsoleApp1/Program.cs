using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateClassExample
{
    class Rectangle
    {
        private double height;
        private double width;
        private double selam;
        static private double spd;
        public void SetData(double h, double w)
        {
            height = h;
            width = w;
        }
        public void SetData(double sa)
        {
            spd = sa;
        }
        public double GetArea()
        {
            return height * width;
        }
        public double GetSpd()
        {
            return spd;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle();
            rect1.SetData(3.4, 10);
            Console.WriteLine("Rectangle area: {0}", rect1.GetArea()); // Sonuç 34
            Rectangle rect2 = new Rectangle();
            Console.WriteLine("Rectangle area: {0}", rect2.GetArea()); // Sonuç 0 , yani değerler objelere özgü
            rect1.SetData(5);
            Console.WriteLine("Rect1 Spd: {0}", rect1.GetSpd()); // Sonuç 5
            Console.WriteLine("Rect2 Spd: {0}", rect2.GetSpd()); // Sonuç 5 , yani değerler class'a özgü
            Console.ReadLine();
        }
    }
}
