using System.Collections;
using System.Collections.Generic;
using StateDesignPattern.StatePattern;

public class StateController //MonoBehaviour
{
    IState _initState, _playState, _pauseState;

    public StateController(IState initState, IState playState, IState pauseState)
    {
        _initState = initState;
        _playState = playState;
        _pauseState = pauseState;
    }

    internal void CheckInput(string input)
    {
        switch (input)
        {
            case "A":
                StateContext.Transition(_initState);
                break;
            case "B":
                StateContext.Transition(_pauseState);
                break;
            case "C":
                StateContext.Transition(_playState);
                break;
            
        } 
    }

    //Unity Methods
    
    // // Start is called before the first frame update
    // void Start()
    // {
    //     // StateContext stateContext = new StateContext();
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     if (Input.GetKeyDown(KeyCode.A))
    //     {
    //         StateContext.Transition(new InitState());
    //     }
    //     else if (Input.GetKeyDown(KeyCode.P))
    //     {
    //         StateContext.Transition(new PauseState());
    //     }
    //     else if (Input.GetKeyDown(KeyCode.Backspace))
    //     {
    //         StateContext.Transition(new PlayState());
    //     }
    // }
}