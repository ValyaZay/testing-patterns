using Test.Characters;

namespace Test.Commands
{
    public class LeftCommand: ICommand
    {
        public void Execute(Player player)
        {
            player.GoLeft();
        }
    }
}