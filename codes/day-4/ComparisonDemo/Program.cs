namespace ComparisonDemo
{
    class Person //: IComparable<Person>
    {
        private int id;
        private string name = "";
        public Person()
        {

        }
        public Person(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

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
            return hash;
        }

        public override bool Equals(object? obj)
        {
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
            return $"{this.GetType().FullName}: {id}, {name}";
        }

        //public int CompareTo(Person? other)
        //{
        //    int result = this.id.CompareTo(other?.id);
        //    if (result == 0)
        //    {
        //        return this.name.CompareTo(other?.name);
        //    }
        //    return result;
        //}
    }
    class PersonComparer : IComparer<Person>
    {
        int _choice;
        public PersonComparer(int choice)
        {
            _choice = choice;
        }
        public int Compare(Person? x, Person? y)
        {
            //int result = x.Id.CompareTo(y?.Id);
            //if (result == 0)
            //{
            //    return x.Name.CompareTo(y?.Id);
            //}
            //return result;

            int result = 0;
            switch (_choice)
            {
                case 1:
                    result = x.Id.CompareTo(y.Id);
                    break;

                case 2:
                    result = x.Name.CompareTo(y.Name);
                    break;

                default:
                    result = x.Id.CompareTo(y?.Id);
                    break;
            }
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person(2, "sunil"));
            people.Add(new Person(3, "anil"));
            people.Add(new Person(1, "joydip"));

            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }
            //this version expects the Person must implement the IComparable<Person> interface and CompareTo() method
            //people.Sort();

            //this version expects the PersonComparer must implement the IComparer<Person> interface and Compare() method
            PersonComparer personComparer = new PersonComparer(1);
            people.Sort(personComparer);


            //for (int i = 0; i < people.Count; i++)
            //{
            //    for (int j = i + 1; j < people.Count; j++)
            //    {
            //        //if (people[i] > people[j])
            //        if (people[i].CompareTo(people[j]) > 0)
            //        {
            //            Person temp = people[i];
            //            people[i] = people[j];
            //            people[j] = temp;
            //        }
            //    }
            //}

            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}
