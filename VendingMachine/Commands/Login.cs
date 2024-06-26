namespace VendingMachine.Commands
{
    class Login : ICommand
    {
        private Router _router;

        public Login(Router router)
        {
            _router = router;
        }

        public void Execute()
        {
            _router.Login();
        }
    }
}
