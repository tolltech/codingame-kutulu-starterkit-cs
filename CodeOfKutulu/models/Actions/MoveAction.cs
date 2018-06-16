using System;

namespace CodeOfKutulu
{
    public class MoveAction : IGameAction
    {
        public string Message { get; }
        public readonly Vec Target;

        public MoveAction(Vec target) : this(target, "") { }

        public MoveAction(Vec target, string message)
        {
            Target = target;
            Message = message;
        }

        public Cancelable ApplyTo(State state)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
            => $"MOVE {Target} {Message}";
    }
}
