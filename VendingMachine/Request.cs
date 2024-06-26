using System.Reflection;

namespace VendingMachine
{
    internal class Request
    {
        public Request(string command, int[] values)
        {
            Command = command;
            Values = values;
        }

        public string Command { get; set; }
        public int[] Values { get; set; }

        public bool IsIncorrectValuesCount(int correct)
        {
            return correct != Values.Length;
        }

        
     
    }
}
