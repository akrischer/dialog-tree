using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class SimpleDialogTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Test1();
        Test2();
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

        Debug.Log(DebugHelper.FormatText("Starting SimpleDialogTest 1...", "yellow"));

        dialogNode.TriggerNode();

        Debug.Log(DebugHelper.FormatText("SimpleDialogTest 1 finished!", "green"));
    }

    void Test2()
    {
        DialogNode dialogueNode1, dialogueNode2, dialogueNode3;
        dialogueNode1 = new DialogNode();
        dialogueNode2 = new DialogNode();
        dialogueNode3 = new DialogNode();

        // dialogueNode1 txts
        TextNode textNode1, textNode2, textNode3;

        // dialogueNode2 txts
        TextNode textNode21, textNode22;

        // dialogueNode3 txts
        TextNode textNode31;

        // setup dialogueNode1
        textNode1 = new TextNode();
        textNode1.SetDisplayText("textNode1");

        textNode2 = new TextNode();
        textNode2.SetDisplayText("textNode2");
        textNode2.SetNextNode(dialogueNode2);

        textNode3 = new TextNode();
        textNode3.SetDisplayText("textNode3");
        textNode3.SetNextNode(dialogueNode3);

        // setup dialogueNode2
        textNode21 = new TextNode();
        textNode21.SetDisplayText("textNode21");
        textNode22 = new TextNode();
        textNode22.SetDisplayText("textNode22");
        dialogueNode2.AcceptTextNodesAsOptions(new List<TextNode> { textNode21, textNode22 });


        // setup dialogueNode3
        textNode31 = new TextNode();
        textNode31.SetDisplayText("textNode31");
        dialogueNode3.AcceptTextNodesAsOptions(new List<TextNode> { textNode31 });

        dialogueNode1.AcceptTextNodesAsOptions(new List<TextNode> { textNode1, textNode2, textNode3 });

        // set it up
        dialogueNode1.AcceptTrigger(OnTrigger);
        dialogueNode2.AcceptTrigger(OnTrigger);
        dialogueNode3.AcceptTrigger(OnTrigger);

        Debug.Log(DebugHelper.FormatText("Starting SimpleDialogTest 2...", "yellow"));

        dialogueNode1.TriggerNode();

        Debug.Log("Triggering textNode1...");
        textNode1.TriggerNode();
        Debug.Log("textNode1 finished!");

        Debug.Log("Triggering textNode2...");
        textNode2.TriggerNode();
        Debug.Log("textNode2 finished!");

        Debug.Log("Triggering textNode3...");
        textNode3.TriggerNode();
        Debug.Log("textNode3 finished!");

        Debug.Log(DebugHelper.FormatText("SimpleDialogTest 2 finished!", "green"));
    }

    void OnTrigger(DialogNodeEvent e)
    {
        e.GetNodeOptions().ForEach(option =>
        {
            Debug.Log(e.name + " Option: " + option.GetDisplayText());
        });
    }
	

}
