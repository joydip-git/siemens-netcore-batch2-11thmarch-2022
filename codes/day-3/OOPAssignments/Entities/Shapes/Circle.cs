namespace Entities.Shapes
{
    //this class can't be inherited any further
    public sealed class Circle : IShape
    {
        private double radius;

        public Circle()
        {

        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public double CalculateArea()
        {
            return radius * radius * Math.PI;
        }
    }
}
