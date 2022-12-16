namespace StateDesignPattern.StatePattern;

public static class StateContext
{
    public static IState? CurrentState;

    public static void Transition(IState? state)
    {
        CurrentState = state;
        CurrentState?.Handle();
    }
}