using System;

namespace CodeOfKutulu
{
    public class YellAction : IGameAction
    {
        public string Message { get; }

        YellAction() : this("") { }

        YellAction(string message)
        {
            Message = message;
        }

        public Cancelable ApplyTo(State state)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
            => "YELL " + Message;
    }
}
