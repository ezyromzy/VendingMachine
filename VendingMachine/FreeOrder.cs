namespace VendingMachine
{
    class FreeOrder : Order
    {
        public FreeOrder(Good good, int count)
            : base(good, count)
        {          
        }

        public override int GetTotalPrice()
        {
            return 0;
        }
    }
}
