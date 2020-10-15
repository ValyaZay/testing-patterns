﻿using Test.Characters;

namespace Test.Commands
{
    public class DownCommand : ICommand
    {
        public void Execute(Player player)
        {
            player.GoDown();
        }
    }
}