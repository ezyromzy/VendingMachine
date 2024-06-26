namespace VendingMachine.Commands
{
    class GetChange : ICommand
    {
        private VendingMachine _machine;

        public GetChange(VendingMachine machine)
        {
            _machine = machine;
        }

        public void Execute()
        {
            _machine.DiscardBalance(_machine.Balance);
        }
    }
}
