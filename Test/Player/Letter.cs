using System;

namespace Test.Player
{
    public class Letter
    {
        public void GoUp()
        {
            Console.WriteLine("I'm going UP...");
        }

        public void GoRight()
        {
            Console.WriteLine("I'm going RIGHT...");
        }
        
        public void GoLeft()
        {
            Console.WriteLine("I'm going LEFT...");
        }
        
        public void GoDown()
        {
            Console.WriteLine("I'm going DOWN...");
        }
        
        public void Unlock() // consider a separate class for this activity
        {
            Console.WriteLine("Unlocking...");
        }
    }
}