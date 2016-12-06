using UnityEngine;
using System.Collections;

public class TextNode : ANode<DialogNodeOption> {

    string displayText;

    public DialogNodeOption GetAsDialogNodeOption()
    {
        return new DialogNodeOption(displayText);
    }

    public void SetDisplayText(string txt)
    {
        displayText = txt;
    }

}
