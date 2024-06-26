namespace VendingMachine
{
    class PayableOrder : Order
    {
        public PayableOrder(Good good, int count)
            : base(good, count)
        {            
        }

        public override int GetTotalPrice()
        {
            return Good.Price * Count;
        }
    }
}
