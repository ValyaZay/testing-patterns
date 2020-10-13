namespace Test
{
    public class Invoker
    {
        private ICommand sequenceCommand;

        public void SetSequenceCommand(ICommand command)
        {
            sequenceCommand = command;
        }

        public void FollowCommandSequence()
        {
            sequenceCommand.Execute();
        }
    }
}