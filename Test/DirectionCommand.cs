namespace Test
{
    public class DirectionCommand : ICommand
    {
        private DirectionHadler directionHadler;
        private string direction;

        public DirectionCommand(DirectionHadler directionHadler, string direction)
        {
            this.directionHadler = directionHadler;
            this.direction = direction;
        }
        public void Execute()
        {
            this.directionHadler.Go(direction);
        }
    }
}