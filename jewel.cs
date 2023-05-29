namespace JewelCollector
{
    class Jewel : Item, IUsable
    {
        public int Points { get; }

        public Jewel(string symbol, int points) : base(symbol)
        {
            Points = points;
        }

        public void Use(Robot robot)
        {
            robot.CollectItem(this);
        }
    }
}
