using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
