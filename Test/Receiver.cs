using System;

namespace Test
{
    public class Receiver
    {
        public void Go(string direction)
        {
            switch (direction)
            {
                case "up": GoUp();
                    break;
                case "down": GoDown();
                    break;
                case "left": GoLeft();
                    break;
                case "right": GoRight();
                    break;
                default: Console.WriteLine("Default case");
                    break;
            }
        }
        private void GoRight()
        {
            Console.WriteLine("I'm going right ");
        }

        private void GoLeft()
        {
            Console.WriteLine("I'm going left ");
        }
        
        private void GoUp()
        {
            Console.WriteLine("I'm going up ");
        }
        
        private void GoDown()
        {
            Console.WriteLine("I'm going down ");
        }
    }
}