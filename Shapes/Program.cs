namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5, Color.Orange);
            Rectangle rectangle = new Rectangle(4, 6, Color.Red);
            Triangle triangle = new Triangle(Color.Blue, 3, 4, 5);
            List<Shape> shapes = new List<Shape>();
            shapes.Add(circle);
            shapes.Add(rectangle);
            shapes.Add(triangle);
            for (int i = 0; i < shapes.Count; i++)
            {
                shapes[i].Tostring();
                Console.WriteLine($"Area: {shapes[i].GetArea()}");
                Console.WriteLine($"Perimeter: {shapes[i].GetPerimeter()}");
                if (shapes[i] is IRolleable rollableShape)
                {
                    rollableShape.Roll();
                }
            }
            Dictionary<string, Shape> shapesDict = new Dictionary<string, Shape>
            {
                {circle.id, circle},
                {rectangle.id, rectangle},
                {triangle.id, triangle}
            };
            foreach (var shape in shapesDict)
            {
                shape.Value.Tostring();
                Console.WriteLine($"Area: {shape.Value.GetArea()}");
                Console.WriteLine($"Perimeter: {shape.Value.GetPerimeter()}");
                if(shape.Value is IRolleable rollableShape)
                {
                    rollableShape.Roll();
                }
            }

            





        }
    }
}
