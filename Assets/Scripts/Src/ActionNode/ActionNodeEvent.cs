using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class ActionNodeEvent : BaseEvent {

    ActionNodeOption actionNodeOption;

    public ActionNodeEvent(ActionNodeOption actionNodeOption)
    {
        bool firstTimeGeneration;
        this.actionNodeOption = actionNodeOption;
        this.name = "DialogeNodeEvent_" + new System.Runtime.Serialization.ObjectIDGenerator().GetId(this, out firstTimeGeneration);
    }

    public UnityAction GetAction()
    {
        return actionNodeOption.GetAction();
    }

    public INode GetNextNode()
    {
        return actionNodeOption.GetNextNode();
    }
}
