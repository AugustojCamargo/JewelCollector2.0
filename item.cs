namespace JewelCollector
{
    abstract class Item
    {
        public string Symbol { get; }

        public Item(string symbol)
        {
            Symbol = symbol;
        }

        public override string ToString()
        {
            return Symbol;
        }
    }
}
