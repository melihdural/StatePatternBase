

namespace StateDesignPattern.StatePattern;

public class PlayState : IState
{
    public void Handle()
    {
        Console.WriteLine("PlayState");
        // Time.timeScale = 1f;
        // Debug.Log("PlayState");
    }
}