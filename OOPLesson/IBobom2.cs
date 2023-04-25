using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLesson
{
    internal interface IBobom2: IBobom3, IBobom4
    {
        public void Rangi()
        {
            Console.WriteLine("Oppog' bo'gan");
        }

        public void Xarakteri() 
        {
            Console.WriteLine("Shustrik");
        }
    }
}
