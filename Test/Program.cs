using System;

namespace Test
{
    class Program
    {
        static void Main()
        {
            string[] directions = {"up", "left", "down", "right"};
            Invoker invoker = new Invoker();
            Receiver receiver = new Receiver();
            invoker.SetSequenceCommand(new Command(receiver, directions));
            
            invoker.FollowCommandSequence();
        }
    }
}