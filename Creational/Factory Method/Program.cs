using System;

namespace FactoryMethod
{
    class MainApp
    {

        static void Main()
        {
            // An array of creators
            Creator[] creators = new Creator[2];

            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();

            // Iterate over creators and create products
            foreach (Creator creator in creators)
            {
                Product product = creator.FactoryMethod();
                Console.WriteLine("Created {0}", product.GetType().Name);
            }

            Console.ReadKey();
        }
    }

    abstract class Product
    {
    }

    class ConcreteProductA : Product
    {
    }

    class ConcreteProductB : Product
    {
    }

    abstract class Creator
    {
        public abstract Product FactoryMethod();
    }

    // Constructs an object of type
    class ConcreteCreatorA : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }

    // Constructs an object of type
    class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }
}