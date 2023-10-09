using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaj1
{
    class Person : IComparable<Person>
    {
        public String Name;
        public String Surname { get; private set; }
        public long Pesel;

        public Person(string name, string surname, long pesel)
        {
            this.Name = name;
            Surname = surname;
            Pesel = pesel;
        }

        public override string ToString()
        {
            return base.ToString() + " "+Name+" "+Surname;
        }

        public int CompareTo(Person other)
        {
            return -1*Surname.CompareTo(other.Surname);
        }

        public override bool Equals(object obj)
        {
            return obj is Person person &&
                   Pesel == person.Pesel;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Pesel);
        }
    }

    class PersonPeselComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return (int) (x.Pesel - y.Pesel);
        }
    }

}

