using Assignment9.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9.Classes
{
    internal class Rectangle : IRectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public double Area => Length * Width;

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle Length = {Length}, Width = {Width}, Area = {Area}");
        }
    }
}
