using Test.Input;

namespace Test
{
    public class UpButton : IButton
    {
        public void OnClick()
        {
            InputHandler.AddUpCommand();
        }
    }
}