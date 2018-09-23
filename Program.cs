using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoker invoker = new Invoker(Client.OpenCommand);
            Invoker invoker2 = new Invoker(Client.OtherCommand);

            invoker.Execute();
            invoker2.Execute();
        }
    }
}
