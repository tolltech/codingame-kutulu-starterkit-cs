namespace CodeOfKutulu
{
    public abstract class Effect
    {
        public readonly Vec Origin;
        public readonly int TimeLeft;
        public readonly int CreatorId;

        public Effect(Vec origin, int timeLeft, int creatorId)
        {
            Origin = origin;
            TimeLeft = timeLeft;
            CreatorId = creatorId;
        }
    }
}
