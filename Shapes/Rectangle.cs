using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Rectangle : Shape
    {
        public int width;
        public int height;
        public Rectangle(int width, int height, Color color) : base(color)
        {
            this.width = width;
            this.height = height;
        }
        public override double GetArea()
        {
            return width * height;
        }
        public override double GetPerimeter()
        {
            return 2 * (width + height);
        }
        public override void Tostring()
        {
            Console.WriteLine($"Rectangle: id={id}, width={width}, height={height}");
        }
    }
    
    
}
