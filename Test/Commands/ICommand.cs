using Test.Player;

namespace Test.Commands
{
    public interface ICommand
    {
        void Execute(Letter letter);
    }
}