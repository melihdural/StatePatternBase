

namespace StateDesignPattern.StatePattern;

public class PauseState : IState
{
    public void Handle()
    {
        Console.WriteLine("PauseState");
        // Time.timeScale = 0f;
        // Debug.Log("PauseState");
    }
    
}