using System;

namespace Zajecia1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person p = new Person("Edyta" ,"Edycka");
            //p.Name = "Olaf";
            //p.Surname = "Olafowski";
            p.PESEL = 92031609876;
            p.SayHello();
            Console.WriteLine(p.PESEL);
            Console.WriteLine(p.Name.Length);
            
        }
    }
}
