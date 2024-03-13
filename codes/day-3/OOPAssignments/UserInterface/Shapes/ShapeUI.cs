using Entities.Shapes;

namespace UserInterface.Shapes
{
    //a static class is a class with ONLY static members (static ctor, data, method, property). No non-static member can be declared inside this type of class
    //an instance of static class is NOT created 
    //this type of class also is known as Utility class
    internal static class ShapeUI
    {
        public static void UseShapes()
        {
            //IShape[] shapes = new IShape[2];
            //shapes[0] = new Circle(12);
            //shapes[1] = new Triangle(12, 3);
            IShape[] shapes = [new Circle(12), new Triangle(12, 3)];
            foreach (IShape shape in shapes)
            {
                Console.WriteLine($"Area of {shape.GetType().Name} is {shape.CalculateArea()}");
            }
        }
    }
}
