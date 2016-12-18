using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using System;

public class ActionNode : ANode<ActionNodeOption> {

    UnityAction action;
    INode nextNode;

    public ActionNode(UnityAction action, INode nextNode = null)
    {
        this.action = action;
        this.nextNode = nextNode;
    }

    public ActionNodeOption GetAsActionNodeOption()
    {
        return new ActionNodeOption(action, nextNode);
    }

    public override void TriggerNode()
    {
        action.Invoke();

        if (nextNode != null)
        {
            nextNode.TriggerNode();
        }
    }
}
