namespace VendingMachine.Commands
{
    class BuyGood : ICommand
    {
        private VendingMachine _machine;
        private IOrder _order;

        public BuyGood(VendingMachine machine, IOrder order)
        {
            _machine = machine;
            _order = order;
        }

        public void Execute()
        {
            _machine.TryProcessOrder(_order);
        }
    }
}
