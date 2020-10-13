namespace Test
{
    public class Command : ICommand
    {
        private Receiver receiver;
        private string[] directions;

        public Command(Receiver receiver, string[] directions)
        {
            this.receiver = receiver;
            this.directions = directions;
        }
        public void Execute()
        {
            foreach (var direction in directions)
            {
                this.receiver.Go(direction);
            }
        }
    }
}