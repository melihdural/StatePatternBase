// See https://aka.ms/new-console-template for more information

using StateDesignPattern.StatePattern;

namespace StateDesignPattern;

class Program
{
    static void Main(string[] args)
    {
        StateController controller = new StateController(new InitState(), new PlayState(), new PauseState());
        while (true)
        {
            controller.CheckInput();
        }
    }
}