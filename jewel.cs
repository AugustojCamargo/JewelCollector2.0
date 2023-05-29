namespace JewelCollector
{
    class Jewel : Item, IUsable //alteração feita por AugustoCamargo2
    {
        public int Points { get; }
        public JewelType Type { get; }
        public bool IsCollected { get; private set; }

        public Jewel(string symbol, int points, JewelType type) : base(symbol) 
        {
            Points = points;
            Type = type;
            IsCollected = false;
        }
        } //Alteração feita por AugustoCamargo1

        public void Use(Robot robot)
        {
            if(!IsCollected)
            {
                robot.CollectItem(this);
                IsCollected = true;
            }
            else
            {
                robot.RechargeEnergy(Points);
            }
        }

        public override string ToString()
        {
            string status = IsCollected ? "Coletado" : "Disponivel";
            return $"Jewel: Type ={Type}, Points = {Points}, Status ={status}"; //Alteração feita por AugustoCamargo2
        }
     //Alteração feita por AugustoCamargo2
    enum JewelType
    {
        Red,
        Green,
        Blue
    }
}
