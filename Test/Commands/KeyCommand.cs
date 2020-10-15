using Test.Characters;

namespace Test.Commands
{
    public class KeyCommand : ICommand
    {
        public void Execute(Player player)
        {
            player.Unlock();
        }
    }
}