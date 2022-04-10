
// See https://aka.ms/new-console-template for more information
using DesignPattern.AbtractFactory;
using DesignPattern.Creational.BuilderPattern;
using DesignPattern.Creational.Prototype;
using DesignPattern.FactoryMethodPattern;
using DesignPattern.SingletonPattern;

Console.WriteLine("Hello, World!");

// Singleton test
LazyInitializedSingleton.Instance();
LazyInitializedSingleton lazyInitializedSingleton2 = LazyInitializedSingleton.Instance();

ThreadSafeLazyInitializedSingleton ThreadSafeLazyInitializedSingleton1 = ThreadSafeLazyInitializedSingleton.Instance();
ThreadSafeLazyInitializedSingleton ThreadSafeLazyInitializedSingleton2 = ThreadSafeLazyInitializedSingleton.Instance();

DoubleCheckLockingSingleton DoubleCheckLockingSingleton1 = DoubleCheckLockingSingleton.Instance();
DoubleCheckLockingSingleton DoubleCheckLockingSingleton2 = DoubleCheckLockingSingleton.Instance();

// Factory method pattern test
IAnimal? animal = AnimalFactory.GetAnimal(ANIMALTYPE.CAT);
if(animal != null)
    animal.animalSound(); // mew mew

// Abtract factory test
FurnitureAbstractFactory? factory = FurnitureFactory.GetFactory(MaterialType.FLASTIC);

if(factory != null)
{
    IChair? chair = factory.CreateObjChair();
    chair.Create();
}

// Test builder pattern
Order order = new FastFoodOrderBuilder()
    .SetOrderType(OrderType.ON_SITE)
    .SetOrderSauce(SauceType.SOY_SAUCE).build();

Console.WriteLine(order.ToString());

// Test prototype
Address address1 = new Address();
address1.Street = "Truong Trinh";
address1.City = "Ha Noi";

Person Person1 = new Person();
Person1.Name = "Person1";
Person1.Age = 18;
Person1.Address = address1;

Person Person2 = Person1.CreateDeepCopy();

Console.WriteLine("person1: " + Person1);
Console.WriteLine("person2: " + Person2);

// CHANGE person 2 info
Address address2 = new Address();
address2.Street = "Bach Mai";
address2.City = "Ha Noi";
Person2.Name = "Person2";
Person2.Age = 30;
Person2.Address = address2;
Console.WriteLine("After change");
Console.WriteLine("person1: " + Person1);
Console.WriteLine("person2: " + Person2);


