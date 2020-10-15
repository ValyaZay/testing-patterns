using System.Collections.Generic;
using Test.Commands;
using Test.Player;

namespace Test.Input
{
    public class InputHandler
    {
        public static List<ICommand> commands = new List<ICommand>();
        public Letter letter;
        public static void AddUpCommand() //onClick() up button on ui
        {
            commands.Add(new UpCommand());
        }
        
        public static void AddRightCommand() //onClick() right button on ui
        {
            commands.Add(new RightCommand());
        }
        
        public static void AddDownCommand() //onClick() down button on ui
        {
            commands.Add(new DownCommand());
        }
        
        public static void AddLeftCommand() //onClick() left button on ui
        {
            commands.Add(new LeftCommand());
        }
        
        public static void AddUnlockCommand() //onClick() key button on ui
        {
            commands.Add(new UnlockCommand());
        }
        
        public void Play() //onClick() play button on ui
        {
            letter = new Letter();
            commands.ForEach(c => c.Execute(letter));
        }
    }
}