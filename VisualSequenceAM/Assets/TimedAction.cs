
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

//Define an action - takes time and has an end - is a class, abstact/virtual, many children classes
//Action child classes have more definition.
//??repeatable???

public class TimedAction
{
    float actionLength;
    bool isFinished;

    //float x = Time.deltaTime;


    //Perform a function 
    virtual public void PerformAction()
    {

    }

    public TimedAction(float actionLength)
    {
        this.actionLength = actionLength;
    }

}

public class DebugLogTextAction : TimedAction
{
    string textToSpitOut;

    public DebugLogTextAction(string textToSpitOut, float actionLength)
        :base(actionLength)
    {
        this.textToSpitOut = textToSpitOut;
    }

    override public void PerformAction()
    {
        Debug.Log(textToSpitOut);
    }

}


// public class MoveCameraAction : TimedAction
// {

//     override public void PerformAction()
//     {
//         //Debug.Log(textToSpitOut);
//     }

// }

// public class ChangeLightingAction : TimedAction
// {

//     override public void PerformAction()
//     {
//         //Debug.Log(textToSpitOut);
//     }

// }





