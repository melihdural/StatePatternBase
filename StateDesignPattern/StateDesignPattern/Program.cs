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
            Console.WriteLine("Type Q to Quit!");
            Console.WriteLine("or");
            Console.WriteLine("Choose: A or B or C");
            var input = Console.ReadLine();
            
            if (input == "Q")
            {
                Console.WriteLine("Bye!");
                break;
            }
            else if (input == "A" || input ==  "B" || input == "C")
            {
                if (input != null) controller.CheckInput(input);
            }
            else
            {
                Console.WriteLine("Invalid Key Try Again!");
            }
            
        }
    }
}