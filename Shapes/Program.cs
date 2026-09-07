namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5,Color.Orange);
            Rectangle rectangle = new Rectangle(4, 6,Color.Red);
            Triangle triangle = new Triangle(Color.Blue, 3,4,5);
            List<Shape> shapes = new List<Shape>();
            shapes.Add(circle);
            shapes.Add(rectangle);
            shapes.Add(triangle);
            for (int i = 0;i < shapes.Count; i++)
            {
                shapes[i].Tostring();
                Console.WriteLine($"Area: {shapes[i].GetArea()}");
                Console.WriteLine($"Perimeter: {shapes[i].GetPerimeter()}");
                if(shapes[i] is IRolleable rollableShape)
                {
                    rollableShape.Roll();
                }
            }




        }
    }
}
