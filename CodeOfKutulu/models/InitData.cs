namespace CodeOfKutulu
{
    public class InitData
    {
        public readonly Cell[,] Map;
        public readonly int SanityLossLonely;
        public readonly int SanityLossGroup;
        public readonly int WandererSpawnTime;
        public readonly int WandererLifeTime;
        public InitData(Cell[,] map, int sanityLossLonely, int sanityLossGroup,
            int wandererSpawnTime, int wandererLifeTime)
        {
            Map = map;
        }
    }
}
