using Assignment9.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment9.Classes
{
    internal class Circle : ICircle
    {
        public double Radius { get; set; }
        public double Area { get { return Math.PI * Radius * Radius; } }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"circle radius = {Radius}, Area = {Area}");
        }
    }
}
