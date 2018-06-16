using System;

namespace CodeOfKutulu
{
    public class PlanAction : IGameAction
    {
        public string Message { get; }

        public PlanAction() : this("") { }

        public PlanAction(string message)
        {
            Message = message;
        }

        public Cancelable ApplyTo(State state)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
            => "PLAN " + Message;
    }
}
