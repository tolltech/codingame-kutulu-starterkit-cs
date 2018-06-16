using System;

namespace CodeOfKutulu
{
    public class WaitAction : IGameAction
    {
        public WaitAction() : this("") { }

        public WaitAction(string message)
        {
            Message = message;
        }

        public string Message { get; }

        public Cancelable ApplyTo(State state)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
            => "WAIT " + Message;
    }
}
