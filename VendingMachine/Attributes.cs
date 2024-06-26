namespace VendingMachine
{
    [AttributeUsage(AttributeTargets.Class,
    AllowMultiple = true, Inherited = false)]
    class CommandAttribute : Attribute
    {
        public string CommandName;

        public CommandAttribute(string commandName)
        {
            CommandName = commandName;
        }
    }
}
