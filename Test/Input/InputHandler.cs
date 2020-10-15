using System.Collections.Generic;
using Test.Characters;
using Test.Commands;

namespace Test.Input
{
    public class InputHandler
    {
        public static List<ICommand> commands = new List<ICommand>();
        public Player player;
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
            commands.Add(new KeyCommand());
        }
        
        public void Play() //onClick() play button on ui
        {
            player = new Player();
            commands.ForEach(c => c.Execute(player));
        }
    }
}