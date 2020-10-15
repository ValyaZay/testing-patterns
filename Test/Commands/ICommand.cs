using Test.Characters;

namespace Test.Commands
{
    public interface ICommand
    {
        void Execute(Player player);
    }
}