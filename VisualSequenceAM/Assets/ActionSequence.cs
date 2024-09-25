


//make it so it takes time to complete action and between actions
//do we need to know what the previous/next action was?
//
//order
//a list of actions, that we perform in the order that inputed into the list
//the actionSequence (the list of actions), performs + something-smethig time
//

using System.Collections.Generic;
using UnityEngine;


public class ActionSequence : MonoBehaviour {
    List<TimedAction> actionSequence;

    public void Start()
    {
        actionSequence = new List<TimedAction>();

        actionSequence.Add(new DebugLogTextAction());
    }

    public void Update()
    {

    }


}
