namespace Entities.OutstandingPerson
{
    public abstract class Person
    {
        private string name = "";

        public Person()
        {
            
        }
        public Person(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public abstract bool IsOutstanding();
    }
}
