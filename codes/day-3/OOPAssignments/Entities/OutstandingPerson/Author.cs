namespace Entities.OutstandingPerson
{
    public class Author : Person
    {
        private int booksPublished;

        public Author()
        {

        }

        public Author(string name, int booksCount) : base(name)
        {
            booksPublished = booksCount;
        }

        public int BooksPublished
        {
            get { return booksPublished; }
            set { booksPublished = value; }
        }
        //this overriden method can't be overriden any further in subsequent child classes in multi-level inheritance
        public sealed override bool IsOutstanding()
        {
            return booksPublished > 0;
        }
    }
}
