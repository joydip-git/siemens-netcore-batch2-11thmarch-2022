namespace Entities.OutstandingPerson
{
    public class Trainee : Person
    {
        private int marks;
        public Trainee()
        {

        }

        public Trainee(string name, int marks) : base(name)
        {
            this.marks = marks;
        }

        public int Marks
        {
            get { return marks; }
            set { marks = value; }
        }

        public override bool IsOutstanding()
        {
            return marks > 85;
        }
    }
}
