using Test.Input;

namespace Test
{
    public class DownButton : IButton
    {
        public void OnClick()
        {
            InputHandler.AddDownCommand();
        }
    }
}