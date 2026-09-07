using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle : Shape
    {
        public int sideA;
        public int sideB;
        public int sideC;
        public Triangle(Color color, int sideA, int sideB, int sideC) : base(color)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }
        public override double GetArea()
        {
            double s = (sideA + sideB + sideC) / 2.0;
            return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));

        }
        public override double GetPerimeter()
        {
            return sideA + sideB + sideC;
        }
        public override void Tostring()
            {
                Console.WriteLine($"Triangle: id={id}, sideA={sideA}, sideB={sideB}, sideC={sideC}");
        }

    }
}
