using Test.Characters;

namespace Test.Commands
{
    public class RightCommand : ICommand
    {
        public void Execute(Player player)
        {
            player.GoRight();
        }
    }
}