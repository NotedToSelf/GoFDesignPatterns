/*
 *
 *
 */


using System;
using System.Collections.Generic;

namespace Prototype
{

    class Program
    {

        static void Main(string[] args)
        {
            Array Cpus = Enum.GetValues(typeof(Cpu));
            Array Gpus = Enum.GetValues(typeof(Gpu));
            Array Motherboards = Enum.GetValues(typeof(Motherboard));
            Random random = new Random();
            bool cont = true;

            while(cont)
            { 
                DesktopComputer p1 = new DesktopComputer(
                    (Gpu)Gpus.GetValue(random.Next(Gpus.Length)), 
                    (Cpu)Cpus.GetValue(random.Next(Cpus.Length)), 
                    (Motherboard)Motherboards.GetValue(random.Next(Motherboards.Length))
                    );
                Console.WriteLine("\nOriginal:");
                p1.Print();
                DesktopComputer c1 = (DesktopComputer)p1.Clone();
                Console.WriteLine("\nCloned:");
                c1.Print();

                // Wait for user
                Console.WriteLine("\n\nPress x to exit, any other key to go again");
                char ret = Console.ReadKey().KeyChar;
                if (ret == 'x')
                {
                    cont = false; 
                }
            }
        }
    }

    enum Gpu
    {
        RTX2080,
        RTX2070,
        RX5700,
        RX590,
        GTX1660,
        GTX1060
    }

    enum Motherboard
    {
        Z390,
        RogXI,
        X570,
        X470,
        B365M
    }

    enum Cpu
    {
        i9,
        i7,
        i5,
        i3
    }

    /// <summary> The 'Prototype' abstract class </summary>
    abstract class Prototype
    {
        public Gpu gpu { get; set; }
        public Cpu cpu { get; set; }
        public Motherboard motherboard { get; set; }

        // Constructor
        public Prototype(Gpu gpu, Cpu cpu, Motherboard motherboard)
        {
            this.gpu = gpu;
            this.cpu = cpu;
            this.motherboard = motherboard;
        }

        public abstract Prototype Clone();

        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine($"Motherboard: { this.motherboard.ToString() }");
            Console.WriteLine($"GPU: { this.gpu.ToString() }");
            Console.WriteLine($"CPU: { this.cpu.ToString() }");
            Console.WriteLine();
        }
    }

    /// <summary> A 'ConcretePrototype' class </summary>
    class DesktopComputer : Prototype
    {
        // Constructor
        public DesktopComputer(Gpu gpu, Cpu cpu, Motherboard motherboard) : base(gpu, cpu, motherboard)
        {
            Console.WriteLine($"Creating Prototype 1");
        }

        // Returns a shallow copy
        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }

    /// <summary> A 'ConcretePrototype' class </summary>
    class ModelTrainer : Prototype
    {
        // Constructor
        public ModelTrainer(Gpu gpu, Cpu cpu, Motherboard motherboard) : base(gpu, cpu, motherboard)
        {
            Console.WriteLine($"Creating Prototype 2");
        }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}