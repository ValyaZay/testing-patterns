using Test.Player;

namespace Test.Commands
{
    public class DownCommand : ICommand
    {
        public void Execute(Letter letter)
        {
            letter.GoDown();
        }
    }
}