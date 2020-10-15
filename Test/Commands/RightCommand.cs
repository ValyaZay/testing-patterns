using Test.Player;

namespace Test.Commands
{
    public class RightCommand : ICommand
    {
        public void Execute(Letter letter)
        {
            letter.GoRight();
        }
    }
}