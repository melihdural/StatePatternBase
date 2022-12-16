namespace StateDesignPattern.StatePattern;

public class InitState : IState
{
    public void Handle()
    {
        Console.WriteLine("InitState");
        // Debug.Log("InitState");
        // LoadLevel();
    }

    // void LoadLevel()
    // {
    //     if (SceneManager.GetActiveScene().buildIndex != 0)
    //     {
    //         SceneManager.LoadScene(0);
    //     }
    //     else
    //     {
    //         SceneManager.LoadScene(1);
    //     }
    // }
}