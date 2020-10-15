using Test.Characters;

namespace Test.Commands
{
    public class UpCommand : ICommand
    {
        public void Execute(Player player)
        {
            player.GoUp();
        }
    }
}