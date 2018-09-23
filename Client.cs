namespace CommandPattern
{
    public class Client
    {
        private static Recevier recevier = new Recevier();

        public static OpenCommand OpenCommand = new OpenCommand(recevier);

        public static OtherCommand OtherCommand = new OtherCommand(recevier);
    }
}