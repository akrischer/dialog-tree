using UnityEngine;
using System.Collections;

public class DialogNodeOption {

    string displayText;

    public DialogNodeOption(string display)
    {
        this.displayText = display;
    }

    public string GetDisplayText()
    {
        return displayText;
    }

}
