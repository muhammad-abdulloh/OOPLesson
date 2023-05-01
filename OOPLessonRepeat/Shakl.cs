namespace OOPLessonRepeat
{
    internal class Shakl
    {

        public Shakl() { Console.WriteLine("Bu static constructor emas"); }

        static Shakl() { Console.WriteLine("bu static constructor"); }

        ~Shakl()
        {
            Console.WriteLine("wwwwwwww");
        }

        public void Tomon()
        {
            Console.WriteLine("Tomonlar");
        }
    }
}
