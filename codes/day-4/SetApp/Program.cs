namespace SetApp
{
    class Person
    {
        private int id;
        private string name = "";

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public override int GetHashCode()
        {
            const int prime = 31;
            int hash = id.GetHashCode() * prime;
            //hash = name.GetHashCode() * hash;
            return hash;
        }

        public override bool Equals(object? obj)
        {
            //this=> current, obj => other
            if (obj == null)
                return false;

            if (obj is Person)
            {
                Person other = (Person)obj;
                if (this == other)
                    return true;

                if (!this.Name.Equals(other.Name))
                    return false;
                if (!this.id.Equals(other.id))
                    return false;

                return true;
            }
            else
                return false;
        }

        public override string ToString()
        {
            //Type type = this.GetType();
            //return $"{type.FullName}";
            return $"{this.GetType().FullName}: {id}, {name}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> numbers = new HashSet<int>();
            numbers.Add(1);//GetHashCode() => 1234
            numbers.Add(2);//GetHashCode() => 4567
            numbers.Add(1);//GetHashCode() => 1234, 1.Equals(1)
            //2^2 => 4
            //2^3 => 8


            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            Person first = new Person();
            first.Name = "anil";
            first.Id = 1;

            Person other = new Person();
            other.Name = "anil";
            other.Id = 2;

            HashSet<Person> people = new HashSet<Person>();
            people.Add(first);//first.GetHashCode() => 890756
            people.Add(other);//other.GetHashCode() => 890756, first.Equals(other)

            foreach (Person p in people)
            {
                //Console.WriteLine(p.ToString());
                Console.WriteLine(p);
            }
        }
    }
}
