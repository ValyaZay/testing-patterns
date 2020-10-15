using Test.Player;

namespace Test.Commands
{
    public class LeftCommand: ICommand
    {
        public void Execute(Letter letter)
        {
            letter.GoLeft();
        }
    }
}