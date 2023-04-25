using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLesson
{
    internal class Vasya: Bobom
    {
        int a = 4;
        int b = 5;
        public int Sum()
        {
            int x = this.a;
            int y = this.b;
            return x + y;
        }

        public void Anything()
        {
            string rang = base.color;

            Console.WriteLine(rang);

            int randomNumber = base.GetRandomNumber();

            Console.WriteLine("Random number: {0}", randomNumber);
        }
        
    }
}
