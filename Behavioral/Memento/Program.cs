using System;

namespace Memento
{
    class MainApp
    {
        static void Main()
        {
            Originator o = new Originator();
            o.State = "State 1";

            Caretaker c = new Caretaker();
            c.Memento = o.CreateMemento();

            o.State = "State 2";
            o.SetMemento(c.Memento);

            Console.ReadKey();
        }
    }

    class Originator
    {
        private string _state;

        // Property
        public string State
        {
            get { return _state; }
            set
            {
                _state = value;
                Console.WriteLine("State = " + _state);
            }
        }

        // Creates memento 

        public Memento CreateMemento()
        {
            return (new Memento(_state));
        }

        // Restores original state

        public void SetMemento(Memento memento)
        {
            Console.WriteLine("Restoring state...");
            State = memento.State;
        }
    }

    class Memento

    {
        private string _state;

        // Constructor

        public Memento(string state)
        {
            this._state = state;
        }

        // Gets or sets state

        public string State
        {
            get { return _state; }
        }
    }

    class Caretaker

    {
        private Memento _memento;

        // Gets or sets memento

        public Memento Memento
        {
            set { _memento = value; }
            get { return _memento; }
        }
    }
}