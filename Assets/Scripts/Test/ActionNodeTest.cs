using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ActionNodeTest : MonoBehaviour {

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
        textNode1.SetNextNode(new ActionNode(SayHi)); // set action node as next node

        textNode2 = new TextNode();
        textNode2.SetDisplayText("textNode2");
        textNode2.SetNextNode(new ActionNode(SaySorry)); // set action node as next node

        textNode3 = new TextNode();
        textNode3.SetDisplayText("textNode3");
        textNode3.SetNextNode(new ActionNode(SayGoodbye)); // set action node as next node

        // dialogNode's text options are now textNode1, textNode2, textNode3
        dialogNode.AcceptTextNodesAsOptions(new List<TextNode> { textNode1, textNode2, textNode3 });

        dialogNode.AcceptTrigger(OnTrigger);

        Debug.Log(DebugHelper.FormatText("Starting ActionNodeTest 1...", "yellow"));

        dialogNode.TriggerNode();

        // Trigger textnode1, should say hi
        textNode1.TriggerNode();

        // Trigger textnode2, should say sorry
        textNode2.TriggerNode();

        // Trigger textnode3, should say goodbye
        textNode3.TriggerNode();

        Debug.Log(DebugHelper.FormatText("ActionNodeTest 1 Finished!", "green"));
    }

    void SayHi()
    {
        Debug.Log(DebugHelper.FormatText("Hi!", "orange"));
    }

    void SaySorry()
    {
        Debug.Log(DebugHelper.FormatText("Sorry!", "orange"));
    }

    void SayGoodbye()
    {
        Debug.Log(DebugHelper.FormatText("Goodbye!", "orange"));
    }

    void OnTrigger(DialogNodeEvent e)
    {
        e.GetNodeOptions().ForEach(option =>
        {
            Debug.Log(e.name + " Option: " + option.GetDisplayText());
        });
    }
}
