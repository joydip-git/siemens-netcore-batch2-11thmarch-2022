namespace PolymorphismApp
{
    class Person
    {
        private string name = "";
        private int id;

        public Person()
        {

        }
        public Person(string name, int id)
        {
            this.name = name;
            this.id = id;
        }

        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }

        private static bool AreSame(Person a, Person b)
        {
            if (!(a.Name == b.Name))
                return false;

            if (!(a.id == b.id))
                return false;

            return true;
        }
        //if(first==second)
        public static bool operator ==(Person a, Person b)
        {
            return AreSame(a, b);
        }
        public static bool operator !=(Person a, Person b)
        {
            return !AreSame(a, b);
        }
        //public static bool operator >(Person a, Person b)
        //public static bool operator <(Person a, Person b)
    }
}
