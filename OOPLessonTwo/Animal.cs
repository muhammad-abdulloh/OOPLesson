using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLessonTwo
{
    /// <summary>
    /// manashu joyda turgan internal shu acess modification deyiladi
    /// </summary>
    public class Animal
    {
        public Animal(string hayvon) { Console.WriteLine("Bu hayvon: " + hayvon); }


        // encapsulation
        protected int number { get; set; }

        protected int GetNumber()
        {
            return number;
        }

        public void SetNumber(int externalNumber)
        {
            this.number = externalNumber;
        }

        // encapsulation
        // to'g'ridan to'g'ri bo'lgan bog'lanishni to'xtatish
        private int GetRandomNumber()
        {
            return 2;
        }

        public int NumberOpkee()
        {
            return GetRandomNumber();
        }
    }
}
