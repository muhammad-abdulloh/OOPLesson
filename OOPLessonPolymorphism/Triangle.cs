using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLessonPolymorphism
{
    internal class Triangle : Shape
    {
        public override int Perimeter(int p)
        {
            throw new NotImplementedException();
        }
        public override int Area(int s)
        {
            return base.Area(s);
        }
    }
}
