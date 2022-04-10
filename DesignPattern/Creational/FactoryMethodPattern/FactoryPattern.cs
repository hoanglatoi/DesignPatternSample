using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethodPattern
{
    // Super class
    // Interface
    public interface IAnimal
    {
        void animalSound(); // interface method (does not have a body)
    }

    // sub class
    // Pig "implements" the IAnimal interface
    public class Pig : IAnimal
    {
        public void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }

    // sub class
    // Cat "implements" the IAnimal interface
    public class Cat : IAnimal
    {
        public void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: mew mew");
        }
    }

    public enum ANIMALTYPE
    {
        PIG,
        CAT
    }

    // Factory class
    public class AnimalFactory
    {
        private AnimalFactory()
        {
        }

        public static IAnimal? GetAnimal(ANIMALTYPE animalType)
        {
            switch (animalType)
            {
                case ANIMALTYPE.PIG:
                    return new Pig();
                case ANIMALTYPE.CAT:
                    return new Cat();
                default: return null;
            }
        }
    }
}
