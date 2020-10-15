using Test.Input;

namespace Test
{
    public class KeyButton : IButton
    {
        public void OnClick()
        {
            InputHandler.AddUnlockCommand();
        }
    }
}