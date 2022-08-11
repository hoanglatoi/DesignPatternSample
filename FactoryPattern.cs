using System;

// Super class
// Interface
interface IAnimal
{
    void animalSound(); // interface method (does not have a body)
}

// sub class
// Pig "implements" the IAnimal interface
class Pig : IAnimal
{
    public void animalSound()
    {
        // The body of animalSound() is provided here
        Console.WriteLine("The pig says: wee wee");
    }
}

// sub class
// Cat "implements" the IAnimal interface
class Cat : IAnimal
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

    public static IAnimal getAnimal(ANIMALTYPE animalType)
    {
        switch (animalType)
        {
            case ANIMALTYPE.PIG:
                return new Pig();
                break;
            case ANIMALTYPE.CAT:
                return new Cat();
                break;
            default: return null;
        }
    }
}

//Client
public class Client
{

    public static void main(String[] args)
    {
        IAnimal animal = new AnimalFactory().getAnimal(ANIMALTYPE.CAT);
        animal.animalSound(); // mew mew
    }
}
