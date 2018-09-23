namespace CommandPattern
{
    public class Invoker
    {
        private Command _command;

        public Invoker(Command command)
        {
            _command = command;
        }

        public void Execute()
        {
            _command.Execute();   
        }

        public void Reverse()
        {
            _command.Undo();
        }
    }
}