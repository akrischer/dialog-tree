using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;
using System.Linq;

public class DialogNode : ANode<DialogNodeEvent> {

    // Every Node class must define its own public sealed class that extends
    // UnityEvent<T>, where "T" is the event type this class fires off (DialogNodeEvent, in this case)
    // This is so we can override Trigger correctly to a discrete event type.
    public sealed class DialogNodeUnityEvent : UnityEvent<DialogNodeEvent> { }

    List<TextNode> dialogOptions = new List<TextNode>();
    
    public DialogNode()
    {
        Trigger = new DialogNodeUnityEvent();
    }

    public void AcceptTextNodesAsOptions(List<TextNode> nodes)
    {
        dialogOptions.AddRange(nodes);
    }

    public List<DialogNodeOption> GetOptions()
    {
        return dialogOptions.Select(dOption => dOption.GetAsDialogNodeOption()).ToList();
    }

    public void TriggerNode()
    {
        TriggerNode(new DialogNodeEvent(GetOptions()));
    }
}
