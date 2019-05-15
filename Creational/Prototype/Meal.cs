using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    /// <summary>
    /// List of possible drinks
    /// </summary>
    public enum Drink
    {
        Soda = 0,
        IcedTea = 1,
        Coffee = 2,
        MilkShake = 3,
        None = 4
    }

    /// <summary>
    /// List of possible sides
    /// </summary>
    public enum Side
    {
        Fries = 0,
        SideSalad = 1,
        OnionRings = 2,
        TaterTots = 3,
        None = 4
    }

    /// <summary>
    /// Represents a fast food meal Prototype
    /// </summary>
    abstract class Meal
    {
        protected string name;
        protected string entree;
        protected List<Drink> drinks;
        protected List<Side> sides;
        protected float total;

        public Meal()
        {
            sides = new List<Side>();
            drinks = new List<Drink>();
        }

        public abstract Meal Clone();
        public abstract void Display();
        public void DisplayBasic()
        {
            Console.Write("\tDrinks: ");
            foreach (Drink d in drinks)
                Console.Write(d.ToString() + "  ");
            Console.Write("\n\tSides: ");
            foreach (Side s in sides)
                Console.Write(s.ToString() + "  ");
            Console.WriteLine();
        }
    }

    class Burger : Meal
    {
        public enum Cheese
        {
            Cheddar,
            PepperJack,
            Swiss,
            Bleu,
            None
        }
        private Cheese cheese;

        public Burger()
        {
            name = "Burger Combo";
            entree = "Cheeseburger";
            cheese = Cheese.Cheddar;
            sides.Add(Side.Fries);
            drinks.Add(Drink.Soda);
        }

        public override Meal Clone()
        {
            return new Burger();
        }

        /// <summary>
        /// Prints the Burger Meal to the console
        /// </summary>
        public override void Display()
        {
            Console.WriteLine("\t" + name);
            Console.WriteLine("\t" + cheese.ToString() + " " + entree);
            DisplayBasic();
        }

    }

    class BBQSalad : Meal
    {
        public enum Dressing
        {
            BBQ = 0,
            Ceasar = 1,
            Ranch = 2,
        }
        
        public enum AddOns
        {
            Chicken = 0,
            Steak = 1,
            Bacon = 2,
            Avocado = 3,
            None = 4
        }

        private Dressing dressing;
        private List<AddOns> addOns;

        public BBQSalad()
        {
            name = "Barbeque Salad Combo";
            entree = "BBQ Salad";
            dressing = Dressing.BBQ;
            addOns = new List<AddOns>();
            addOns.Add(AddOns.None);
            
            //Delete these
            NewAddOn(AddOns.Chicken);
            NewAddOn(AddOns.Avocado);
            
            drinks.Add(Drink.IcedTea);
            sides.Add(Side.None);
        }

        public override Meal Clone()
        {
            return new BBQSalad();
        }

        /// <summary>
        /// Adds an extra add on to the order
        /// </summary>
        public void NewAddOn(AddOns toAdd)
        {
            if(addOns.Contains(AddOns.None))
                addOns.Remove(AddOns.None);

            addOns.Add(toAdd);
        }

        public override void Display()
        {
            Console.WriteLine("\t" + name);
            Console.WriteLine("\t" + entree + " with " + dressing.ToString() + " dressing");
            Console.Write("\tAddOns: ");

            foreach (AddOns addon in addOns)
                Console.Write(addon + "  ");
            
            Console.WriteLine();
            DisplayBasic();
        }
    }

    class Custom : Meal
    {
        public Custom()
        {
            name = "Create Your Own Combo";
            entree = "None";
            sides.Add(Side.None);
            drinks.Add(Drink.None);
        }

        public override Meal Clone()
        {
            return new Custom();
        }

        public override void Display()
        {
            DisplayBasic();
        }
    }
}
