namespace Test
{
    public class UnlockCommand : ICommand
    {
        private UnlockHandler unlockHandler;

        public UnlockCommand(UnlockHandler unlockHandler)
        {
            this.unlockHandler = unlockHandler;
        }
        public void Execute()
        {
            this.unlockHandler.Unlock();
        }
    }
}