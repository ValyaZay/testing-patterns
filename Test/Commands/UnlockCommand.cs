using Test.Player;

namespace Test.Commands
{
    public class UnlockCommand : ICommand
    {
        public void Execute(Letter letter)
        {
            letter.Unlock();
        }
    }
}