namespace VendingMachine
{
    internal class Good
    {
        public Good(string name, int price, int count)
        {
            Name = name;
            Price = price;
            Count = count;
        }

        public string Name { get; private set; }
        public int Price { get; private set; }
        public int Count { get; set; }


    }
}
