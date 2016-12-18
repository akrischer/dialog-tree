using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class ActionNodeOption : MonoBehaviour {

    UnityAction action;
    INode nextNode;

    public ActionNodeOption(UnityAction action, INode nextNode)
    {
        this.action = action;
        this.nextNode = nextNode;
    }

    public UnityAction GetAction()
    {
        return action;
    }

    public INode GetNextNode()
    {
        return nextNode;
    }
}
