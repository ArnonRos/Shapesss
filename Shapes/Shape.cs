using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        private static int nextid = 1;
        public int id { get; set; }
        public Color color { get; set; }
        public Shape(Color color)
        {
            id = nextid;
            nextid++;
            this.color = color;
        }
        public abstract double GetArea();
        public abstract double GetPerimeter();
        public abstract void Tostring();



    }
}
