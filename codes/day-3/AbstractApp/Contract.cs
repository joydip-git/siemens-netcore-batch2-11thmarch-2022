namespace AbstractApp
{
    abstract class Contract
    {
        private int _guid;

        public Contract() { }
        public Contract(int guid) { _guid = guid; }

        public int Guid { set => _guid = value; get => _guid; }

        public int Print()
        {
            return _guid;
        }

        public abstract void Foo();
        public abstract string Name { set; get; }
    }
    abstract class PartialImplementation : Contract
    {

        private string? _name;

        public PartialImplementation() { }
        public PartialImplementation(int guid, string? name)
        : base(guid)
        {
            _name = name;
        }

        // abstractmethod is not implemented here	
        // public override void Foo(){ //code }

        // implementation of abstract property
        public override string? Name
        {
            set => _name = value;
            get => _name;
        }
    }
    class Implementation : Contract
    {

        private string? _name;
        public Implementation() { }
        public Implementation(int guid, string? name)
        : base(guid)
        {
            _name = name;
        }

        //implementation of abstract methdo and property
        public override void Foo()
        {
            //code
        }

        public override string? Name
        {
            set => _name = value;
            get => _name;
        }

        public void Show()
        {
            Console.WriteLine(_name);
        }
    }
}
