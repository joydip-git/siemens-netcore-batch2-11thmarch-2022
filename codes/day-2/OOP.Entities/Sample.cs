namespace OOP.Entities
{
    internal class Sample
    {
        public void Create()
        {
            Person person = new Person();
           // person.name = "";//internal but readonly
            //person.age = 0; //public=> private
            person.GetInfo();
        }
    }
}
