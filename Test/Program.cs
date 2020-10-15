using System;
using System.IO.MemoryMappedFiles;
using Test.Commands;

namespace Test
{
    class Program
    {
        static void Main()
        {
            IButton right = new RightButton();
            IButton up = new UpButton();
            IButton down = new DownButton();
            IButton left = new LeftButton();
            IButton key = new KeyButton();
            IButton play = new PlayButton();
            
            // consider this command set: right, right, up, up, left, key
            right.OnClick();
            right.OnClick();
            up.OnClick();
            up.OnClick();
            left.OnClick();
            key.OnClick();
            
            // when set of commands is ready, click Play button
            play.OnClick();
        }
    }
}