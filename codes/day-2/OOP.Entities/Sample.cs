namespace OOP.Entities
{
    internal class Sample
    {
        public void Create()
        {
            Person person = new Person();
            person.name = "";//internal
            person.age = 0; //public
            person.GetInfo();
        }
    }
}
