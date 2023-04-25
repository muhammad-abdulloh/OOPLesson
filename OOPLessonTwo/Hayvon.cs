using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLessonTwo
{
    internal class Hayvon : Animal
    {
        public Hayvon(string hayvon) : base(hayvon)
        {
            
        }

        Hayvon hayvon = new Hayvon("Mushuk");

        int a = 4;
        int b = 5;

        int sum = 0;

        public void Davay()
        {
            sum = a + b;
            hayvon.GetNumber();
        }

    }
}
