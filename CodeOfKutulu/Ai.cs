using System.Collections.Generic;
using System.Linq;

namespace CodeOfKutulu
{
    class Ai
    {
        public Ai()
        {
        }

        public IGameAction GetNextAction(State state, Countdown countdown)
        {
            var me = state.Me.Position;
            var others = state.Others.OrderByDescending(x => x.Sanity / 25).ThenBy(x => x.Position.DistTo(me)).Select(x => x.Position);

            var possibles = new List<Vec>();
            var stops = state.GetStopVecs(me).ToArray();
            foreach (var stop in stops)
            {
                possibles.Add(me.OppositeTo(stop));
            }

            var emptys = state.GetNeighbours(me, Cell.Empty);

            return possibles.FirstOrDefault(state.HasVector)?.ToMoveAction() ?? new MoveAction(new Vec(state.Width - 1, state.Height - 1));
        }
    }
}