using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia1
{
    class Person
    {
        public String Name;
        public String Surname;
        public long PESEL;

        public Person() : this("John", "Doe")
        {
            //Name = "John";
            //Surname = "Doe";
        }

        public Person(String name, String Surname)
        {
            Name = name;
            this.Surname = Surname;
        }
        public void SayHello()
        {
            Console.WriteLine("Hello I'm " + Name + " " + Surname);
        }
    }
}
