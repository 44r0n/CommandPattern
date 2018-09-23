namespace CommandPattern
{
    public class OpenCommand : Command
    {
        private readonly Recevier _recevier;

        public OpenCommand(Recevier recevier)
        {
            _recevier = recevier;
        }
        public void Execute()
        {
            System.Console.WriteLine("Execute open command.");
            _recevier.OpenExample();
        }

        public void Undo()
        {
            throw new System.NotImplementedException();
        }
    }
}