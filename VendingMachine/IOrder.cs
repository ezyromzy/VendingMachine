namespace VendingMachine
{
    internal interface IOrder
    {
        bool IsAvailable { get; }

        int GetTotalPrice();
        void Ship();
    }
}
