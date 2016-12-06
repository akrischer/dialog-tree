using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class SimpleDialogTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Test1();
    }

    void Test1()
    {
        DialogNode dialogNode = new DialogNode();

        TextNode textNode1, textNode2, textNode3;
        textNode1 = new TextNode();
        textNode1.SetDisplayText("textNode1");

        textNode2 = new TextNode();
        textNode2.SetDisplayText("textNode2");

        textNode3 = new TextNode();
        textNode3.SetDisplayText("textNode3");

        dialogNode.AcceptTextNodesAsOptions(new List<TextNode> { textNode1, textNode2, textNode3 });

        // set it up
        dialogNode.AcceptTrigger(OnTrigger);

        Debug.Log("Starting SimpleDialogTest 1...");

        dialogNode.TriggerNode();

        Debug.Log("SimpleDialogTest 1 finished!");
    }

    void OnTrigger(DialogNodeEvent e)
    {
        e.GetNodeOptions().ForEach(option =>
        {
            Debug.Log(e.name + " Option: " + option.GetDisplayText());
        });
    }
	

}
