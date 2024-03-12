namespace Inheritance
{
    public class Car //:Object (GetType, GetHashCode, Equals and ToString)
    {
        //protected string modelName = "";
        //protected string chasisNo = "";
        //protected string bodyColor = "";

        private string modelName = "";
        private string chasisNo = "";
        private string bodyColor = "";

        public Car()
        {
            Console.WriteLine("default ctor of Car");
        }
        public Car(string modelName, string chasisNo, string bodyColor)
        {
            Console.WriteLine("parameterized ctor of Car");
            this.modelName = modelName;
            this.chasisNo = chasisNo;
            this.bodyColor = bodyColor;
        }
        public string ModelName { get => modelName; set => modelName = value; }
        public string ChasisNo { get => chasisNo; set => chasisNo = value; }
        public string BodyColor { get => bodyColor; set => bodyColor = value; }

        public string GetInfo() => $"{modelName}, {chasisNo}, {bodyColor}";
    }
    internal class Maruti : Car
    {
        bool hasTouchScreen;
        bool hasHillControl;

        public Maruti()
        {
            Console.WriteLine("default ctor of Maruti");
        }
        //base keyword is used to access accessible members of immediate base class 
        //ex: invoking base class public instance constructors
        //since by default the default base class constructor will be called by runtime, hence you can invoke any other parameterized ctor of base class using this "base" keyword from child class's constructor
        public Maruti(string modelName, string chasisNo, string bodyColor, bool hasTouchScreen, bool hasHillControl) : base(modelName, chasisNo, bodyColor)
        {
            Console.WriteLine("parameterized ctor of Maruti");
            //accessing public inherited properties of base class to assign the value to private (still inherited, but inaccessible) data members
            //this.ModelName = modelName;
            //this.BodyColor=bodyColor;
            //this.ChasisNo = chasisNo;
            //assigning values to class's own data members directly
            this.hasTouchScreen = hasTouchScreen;
            this.hasHillControl = hasHillControl;
        }

        public bool HasTouchScreen { get => hasTouchScreen; set => hasTouchScreen = value; }
        public bool HasHillControl { get => hasHillControl; set => hasHillControl = value; }

        public string GetInfo() => $"{base.GetInfo()}, {hasHillControl}, {hasTouchScreen}";
    }
}
