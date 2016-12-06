using System.Collections.Generic;

[System.Serializable]
public class DialogNodeEvent : BaseEvent {

    List<DialogNodeOption> dialogNodeOptions;

    public DialogNodeEvent(List<DialogNodeOption> dialogNodeOptions)
    {
        bool firstTimeGeneration;
        this.dialogNodeOptions = dialogNodeOptions;
        this.name = "DialogeNodeEvent_" + new System.Runtime.Serialization.ObjectIDGenerator().GetId(this, out firstTimeGeneration);
    }

    public List<DialogNodeOption> GetNodeOptions()
    {
        return dialogNodeOptions;
    }
}
