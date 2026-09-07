using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Circle : Shape, IRolleable
    {
        public int radius;
        public Circle(int radius, Color color) : base(color)
        {
            this.radius = radius;
        }
        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
        public override double GetPerimeter()
        {
            return 2 * Math.PI * radius;
        }
        public override void Tostring()
        {
            Console.WriteLine($"Circle: id={id}, radius={radius}");
        }
        public void Roll()
        {
            Console.WriteLine($"Circle with id={id} is rolling.");
        }
    }

}
