using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

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
