using System;
using System.Collections.Generic;

namespace Zaj1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person p = new Person("John", "Doe", 767765672L);
            Console.WriteLine("Hello " + p);
            Person[] _persons = new Person[7];
            _persons = new Person[] { new Person("A", "AA", 12L), new Person("B", "BB", 8765L) };
            List<Person> persons = new List<Person>();
            foreach (Person _p in _persons)
            {
                persons.Add(_p);
            }
            persons.Add(p);
            persons.Sort();
            foreach(Person _p in persons)
            {
                Console.WriteLine(_p);
            }
            Console.WriteLine("==============");
            persons.Sort(new PersonPeselComparer());
            foreach (Person _p in persons)
            {
                Console.WriteLine(_p);
            }

            Dictionary<Person, float> salaries = new Dictionary<Person, float>();
            salaries.Add(p, 7523);
            salaries.Add(persons[1], 1234);
            foreach (Person _p in salaries.Keys)
            {
                Console.WriteLine(_p + " zarabia " + salaries[_p]);
            }
            //rozmiar listy persons.Count;
            //rozmiar tablicy _persons.Length;


        }
    }
}
