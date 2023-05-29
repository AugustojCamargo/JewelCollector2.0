namespace JewelCollector
{
    class Jewel : Item, IUsable //alteração feita por AugustoCamargo2
    {
        public int Points { get; }

        public Jewel(string symbol, int points, JewelType type) : base(symbol) 
        {
            Points = points;
            Type = type;
        } //Alteração feita por AugustoCamargo1

        public void Use(Robot robot)
        {
            robot.CollectItem(this);
            robot.Item(points); //alteração feita por AugustoCamargo1
        }

        public override string ToString()
        {
            return $"J{Points}"; //Alteração feita por AugustoCamargo2
        }
    }
}

    enum JewelType //Alteração feita por AugustoCamargo1
    {
        Red,
        Green,
        Blue
    }
