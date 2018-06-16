namespace CodeOfKutulu
{
    public class CellInfo
    {
        public CellInfo(Vec vec, Cell cell)
        {
            Vec = vec;
            Cell = cell;
        }

        public Vec Vec { get; set; }
        public Cell Cell { get; set; }
    }
}