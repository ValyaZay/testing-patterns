using Test.Input;

namespace Test
{
    public class RightButton : IButton
    {
        public void OnClick()
        {
            InputHandler.AddRightCommand();
        }
    }
}