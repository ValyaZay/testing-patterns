using Test.Input;

namespace Test
{
    public class PlayButton: IButton
    {
        public void OnClick()
        {
            InputHandler inputHandler = new InputHandler();
            inputHandler.Play();
        }
    }
}