using Test.Input;

namespace Test
{
    public class LeftButton : IButton
    {
        public void OnClick()
        {
            InputHandler.AddLeftCommand();
        }
    }
}