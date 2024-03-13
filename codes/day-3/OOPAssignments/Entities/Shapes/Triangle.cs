namespace Entities.Shapes
{
    public sealed class Triangle : IShape
    {
        private double tBase;
        private double tHeight;

        public Triangle()
        {

        }
        public Triangle(double tBase, double tHeight)
        {
            this.tBase = tBase;
            this.tHeight = tHeight;
        }

        public double THeight
        {
            get { return tHeight; }
            set { tHeight = value; }
        }
        public double TBase
        {
            get { return tBase; }
            set { tBase = value; }
        }

        public double CalculateArea()
        {
            return 0.5 * tBase * tHeight;
        }
    }
}
