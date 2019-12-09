using System;

namespace State
{

    class MainApp
    {

        static void Main()
        {
            // Setup context in a state

            Context c = new Context(new ConcreteStateA());

            // Issue requests, which toggles state

            c.Request();
            c.Request();
            c.Request();
            c.Request();

            // Wait for user

            Console.ReadKey();
        }
    }

    abstract class State

    {
        public abstract void Handle(Context context);
    }

    class ConcreteStateA : State

    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateB();
        }
    }

    class ConcreteStateB : State

    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateA();
        }
    }

    class Context

    {
        private State _state;

        // Constructor

        public Context(State state)
        {
            this.State = state;
        }

        // Gets or sets the state

        public State State
        {
            get { return _state; }
            set

            {
                _state = value;
                Console.WriteLine("State: " +
                  _state.GetType().Name);
            }
        }

        public void Request()
        {
            _state.Handle(this);
        }
    }
}