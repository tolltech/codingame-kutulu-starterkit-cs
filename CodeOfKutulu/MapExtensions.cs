using System.Collections.Generic;
using System.Linq;

namespace CodeOfKutulu
{
    public static class MapExtensions
    {
        public static IEnumerable<CellInfo> GetNeighbours(this State state, Vec vec, params Cell[] cells)
        {
            for (var x = -1; x < 2; ++x)
                for (var y = -1; y < 2; ++y)
                {
                    if (x == 0 && y == 0)
                        continue;

                    var step = vec + new Vec(x, y);

                    if (!state.HasVector(step))
                    {
                        continue;
                    }

                    var c = state.GetAt(step);
                    if (cells == null || cells.Length == 0 || cells.Contains(c))
                        yield return new CellInfo(step, c);
                }
        }

        public static bool HasVector(this State state, Vec vec)
        {
            return !(vec.X < 0 || vec.Y < 0 || vec.X >= state.Width || vec.Y >= state.Height);
        }

        public static IEnumerable<Vec> GetWanderVecs(this State state, Vec vec)
        {
            var me = vec;
            var wanderers = state.Wanderers.Select(x => x.Position).OrderBy(x => x.X == me.X || x.Y == me.Y ? 0 : 1).ThenBy(x => x.ManhattanDistTo(me));
            foreach (var wanderer in wanderers)
            {
                yield return wanderer;
            }
        }

        public static IEnumerable<Vec> GetStopVecs(this State state, Vec vec)
        {
            return state.GetWanderVecs(vec).Where(x => x.ManhattanDistTo(vec) == 1);
        }

        public static Vec OppositeTo(this Vec me, Vec opposite)
        {
            return (opposite - me).Rotate90CW().Rotate90CW() + me;
        }

        public static MoveAction ToMoveAction(this Vec vec)
        {
            return new MoveAction(vec);
        }
    }
}