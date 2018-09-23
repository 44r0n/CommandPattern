namespace CommandPattern
{
    public class OtherCommand : Command
    {
        private readonly Recevier _reciever;

        public OtherCommand(Recevier recevier)
        {
            _reciever = recevier;
        }
        public void Execute()
        {
            System.Console.WriteLine("Execute Other command.");
            _reciever.OtherExample();
        }

        public void Undo()
        {
            System.Console.WriteLine("Undo Other command.");
            _reciever.SecondExample();
        }
    }
}