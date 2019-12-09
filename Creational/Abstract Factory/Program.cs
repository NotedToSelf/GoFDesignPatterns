using System;

namespace AbstractFactory
{
    class Program
    {

        public static void Main()
        {
            // Build for Andriod
            AbstractFactory AndriodFactory = new AndriodBuild();
            Client AndriodApp = new Client(AndriodFactory);
            AndriodApp.Run();

            Console.WriteLine();
            
            // Build for iPhone
            AbstractFactory AppleFactory = new AppleBuild();
            Client IphoneApp = new Client(AppleFactory);
            IphoneApp.Run();

            Console.ReadKey();
        }
    }

    // Abstract Factory class defining the components needed for each Concrete Factory
    abstract class AbstractFactory
    {
        public abstract AbstractAssets BundleAssets();
        public abstract AbstractApp BuildForPlatform();
    }

    // Defines the specific build operations for Andriod
    class AndriodBuild : AbstractFactory
    {

        public override AbstractAssets BundleAssets()
        {
            Console.WriteLine("Bundling Andiod Assets");
            return new AndriodAssets();
        }

        public override AbstractApp BuildForPlatform()
        {
            Console.WriteLine("Starting Andriod Build");
            return new AndriodExecutable();
        }
    }

    // Defines the specific build operations for Apple
    class AppleBuild : AbstractFactory
    {
        public override AbstractAssets BundleAssets()
        {
            Console.WriteLine("Bundling Apple Assets");
            return new AppleAssets();
        }
        public override AbstractApp BuildForPlatform()
        {
            Console.WriteLine("Starting iPhone Build");
            return new AppleExecutable();
        }
    }

    // Defines abstract asset operations
    abstract class AbstractAssets
    {
        //abstract Assets requestAssets(); for example
    }

    // Defines abstract app operations
    abstract class AbstractApp
    {
        public abstract void BuildWithAssets(AbstractAssets a);
    }

    // Andriod implementation of asset operations
    class AndriodAssets : AbstractAssets
    {
    }

    // Andriod implementation of app operations
    class AndriodExecutable : AbstractApp
    {
        public override void BuildWithAssets(AbstractAssets a)
        {
            Console.WriteLine("Building Andriod app with assets: " + a.GetType().Name);
        }
    }

    // Apple implementation of asset operations
    class AppleAssets : AbstractAssets
    {
    }

    // Apple implementation of build operations
    class AppleExecutable : AbstractApp
    {
        public override void BuildWithAssets(AbstractAssets a)
        {
            Console.WriteLine("Building Apple app with assets: " + a.GetType().Name);
        }
    }

    // Defines the generic build process for both apps
    class Client
    {
        private AbstractAssets _abstractAssets;
        private AbstractApp _abstractBuild;

        public Client(AbstractFactory factory)
        {
            _abstractAssets = factory.BundleAssets();
            _abstractBuild = factory.BuildForPlatform();
        }

        public void Run()
        {
            _abstractBuild.BuildWithAssets(_abstractAssets);
        }
    }
}