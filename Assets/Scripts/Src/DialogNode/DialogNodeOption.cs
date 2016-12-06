using UnityEngine;
using System.Collections;

public class DialogNodeOption {

    string displayText;
    INode nextNode;

    public DialogNodeOption(string display, INode nextNode = null)
    {
        this.displayText = display;
        this.nextNode = nextNode;
    }

    public string GetDisplayText()
    {
        return displayText;
    }

    public INode GetNextNode()
    {
        return nextNode;
    }

}
