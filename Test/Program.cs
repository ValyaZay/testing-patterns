using System;

namespace Test
{
    class Program
    {
        static void Main()
        {
            string[] directions = {"up", "left", "unlock", "down", "right", "down", "unlock"};
            Invoker invoker = new Invoker();
            DirectionHadler directionHadler = new DirectionHadler();
            UnlockHandler unlockHandler = new UnlockHandler();

            invoker.SetUnlockCommand(new UnlockCommand(unlockHandler));

            foreach (var direction in directions)
            {
                invoker.SetDirectionCommand(new DirectionCommand(directionHadler, direction));
                if (direction == "unlock")
                {
                    invoker.ExecuteUnlockCommand();
                }
                else
                {
                    invoker.ExecuteDirectionCommand();
                }
                
            }
        }
    }
}