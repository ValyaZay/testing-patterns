using Test.Player;

namespace Test.Commands
{
    public class UpCommand : ICommand
    {
        public void Execute(Letter letter)
        {
            letter.GoUp();
        }
    }
}