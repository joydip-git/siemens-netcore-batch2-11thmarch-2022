namespace PolymorphismApp
{
    class Bird
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("default sound");
        }
    }
    class Flamingo : Bird
    {
        public override void MakeSound()
        {
            Console.WriteLine("Flamigo sound.... ");
        }
    }
    class IrishFlamingo : Flamingo
    {
        public override void MakeSound()
        {
            Console.WriteLine("Irish flamingo sound");
        }
    }

    class Parrot : Bird
    {
        public override void MakeSound()
        {
            Console.WriteLine("Parrot sound.... ");
        }
    }
}
