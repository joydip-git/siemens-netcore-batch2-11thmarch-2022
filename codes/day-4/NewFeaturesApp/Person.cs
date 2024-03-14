namespace NewFeaturesApp
{
    internal class Person
    {
        /*
        private int id;
        private string name="";

        public string? Name
        {
            get => name;
            set => name = value;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }
        */

        //public abstract string? Name { get; set; }

        /**
         *  private int _<Id>.BackingField;
            private string? _<Name>,BackingField;
            public int Id { get=>_<Id>.BackingField; set=> _<Id>.BackingField=value;}
         */
        //automatic properties
        public required int Id { get; set; }
        
        //auto-property initializer
        public required string Name { get; set; } = "";

        public Person()
        {

        }

        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
