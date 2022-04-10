using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Clone with better performance

namespace DesignPattern.Creational.Prototype
{
    public interface IPrototype<T>
    {
        T CreateDeepCopy();
    }

    public class Person : IPrototype<Person>
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public Address? Address { get; set; }

        public Person CreateDeepCopy()
        {
            var person = (Person)MemberwiseClone();
            person.Address = Address.CreateDeepCopy();
            return person;
        }

        public override String ToString()
        {
            return "Name=" + Name + ", Age=" + Age + ", Address=" + Address;
        }
    }

    public class Address : IPrototype<Address>
    {
        public string? City { get; set; }
        public string? Street { get; set; }

        public Address CreateDeepCopy()
        {
            return (Address)MemberwiseClone();
        }

        public override String ToString()
        {
            return "City=" + City + ", Street=" + Street ;
        }
    }
}
