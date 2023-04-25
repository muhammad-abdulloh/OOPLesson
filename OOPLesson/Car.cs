using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLesson
{
    internal class Car
    {
        public Car()
        {
            
        }

        public Car(string name, string color, string speed = "220 km/h")
        {
            // string formatlash
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Color: {0}", color);
            Console.WriteLine("Speed: {0}", speed);
        }

        //public void Name(string name)
        //{
        //    Console.WriteLine("Mashina nomi: {0}", name);
        //}

        //public void Speed(string speed)
        //{
        //    Console.WriteLine("Tezlik: {0}", speed);
        //}

        //public void Color(string color) 
        //{
        //    Console.WriteLine("Rangi: {0}", color);
        //}
    }
}
