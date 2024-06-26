        namespace VendingMachine.Commands
{
    class ShowCommands : ICommand
    {
        private Router _router;

        public ShowCommands(Router router)
        {
            _router = router;
        }

        public void Execute()
        {
            foreach (string command in _router.GetCommands())
                Console.WriteLine(command);
        }
    }
}
