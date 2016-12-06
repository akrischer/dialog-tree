using UnityEngine;
using System.Collections;
using System;

[System.Serializable]
public class TextNode : ANode<DialogNodeOption> {

    [SerializeField]
    string displayText;
    [SerializeField]
    INode nextNode;

    public DialogNodeOption GetAsDialogNodeOption()
    {
        return new DialogNodeOption(displayText, nextNode);
    }

    public void SetDisplayText(string txt)
    {
        displayText = txt;
    }

    public void SetNextNode(INode node)
    {
        nextNode = node;
    }

    public override void TriggerNode()
    {
        if (nextNode != null)
        {
            nextNode.TriggerNode();
        }
    }

}
