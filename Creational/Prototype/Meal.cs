using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{

    public enum Drink
    {
        Coke,
        Pepsi,
        Sprite,
        IcedTea,
        Coffee,
        MtnDew,
        MilkShake
    }

    public enum Side
    {
        Fries,
        Salad,
        OnionRings,
        TaterTots,
    }

    /// <summary>
    /// Represents a fast food meal Prototype
    /// </summary>
    abstract class Meal
    {
        private string name;
        private Drink[] drinks;
        private Side[] sides;
        private float total; //Adjusted by certain sides or drinks

        public abstract void Clone();
    }

    class Burger : Meal
    {
        Burger()
        {

        }

        public override void Clone()
        {

        }

    }

    class Salad : Meal
    {
        Salad ()
        {

        }

        public override void Clone()
        {

        }
    }

}
