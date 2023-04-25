using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLessonPolymorphism
{
    internal abstract class Shape
    {
        // virtual kalit so'zi qo'yiladigan bo'lsa 
        // uni qayta yozish ixtiyoriy
        public virtual int Area(int s)
        {
            return s;
        }

        // abstract kalit so'zini qo'yadigan bo'sam
        // bu methodni qayta yoishim majburiy bo'ladi
        public abstract int Perimeter(int p);
        
    }
}
