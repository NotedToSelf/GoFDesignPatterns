using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{

    public enum Drink
    {
        Soda,
        IcedTea,
        Coffee,
        MilkShake,
        None
    }

    public enum Side
    {
        Fries,
        SideSalad,
        OnionRings,
        TaterTots,
        None
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
    }

    class Burger : Meal
    {
        private enum Cheese
        {
            Cheddar,
            PepperJack,
            Swiss,
            Bleu,
            None
        }
        private Cheese cheese;

        Burger()
        {
            name = "Burger Combo";
            cheese = Cheese.Cheddar;
            sides.Add(Side.Fries);
            drinks.Add(Drink.Soda);
        }

        public override Meal Clone()
        {
            return new Burger();
        }

        public void Display()
        {

        }

    }

    class BBQSalad : Meal
    {
        private enum Dressing
        {
            BBQ,
            Ceasar,
            Ranch,
        }
        
        private enum AddOns
        {
            Chicken = 2,
            Steak = 3,
            Bacon = 2,
            Avocado = 2,
            None = 0
        }

        private Dressing dressing;
        private AddOns addOns;

        BBQSalad()
        {
            name = "Barbeque Salad Combo";
            
            dressing = Dressing.BBQ;
            addOns = AddOns.None;
            
            drinks.Add(Drink.IcedTea);
            sides.Add(Side.None);
        }

        public override Meal Clone()
        {
            return new BBQSalad();
        }
    }



    class Custom : Meal
    {
        Custom()
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
    }
}
