namespace Test
{
    public class Invoker
    {
        private ICommand directionCommand;
        private ICommand unlockCommand;

        public void SetDirectionCommand(ICommand command)
        {
            directionCommand = command;
        }

        public void SetUnlockCommand(ICommand command)
        {
            unlockCommand = command;
        }
        
        public void ExecuteDirectionCommand()
        {
            directionCommand.Execute();
        }
        
        public void ExecuteUnlockCommand()
        {
            unlockCommand.Execute();
        }
    }
}