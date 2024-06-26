namespace VendingMachine.Commands
{
    [Command("AddMoney")]
    class AddMoney : ICommand
    {
        private VendingMachine _machine;
        private int _money;

        public AddMoney(VendingMachine machine, int money)
        {
            _machine = machine;
            _money = money;
        }

        public void Execute()
        {
            _machine.AddBalance(_money);
        }
    }
}
