using System;

namespace CodeOfKutulu
{
    public class LightAction : IGameAction
    {
        public string Message { get; }

        public LightAction() : this("") { }

        public LightAction(string message)
        {
            Message = message;
        }

        public Cancelable ApplyTo(State state)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
            => "LIGHT " + Message;
    }
}
