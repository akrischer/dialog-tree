using UnityEngine;
using UnityEngine.Events;
using System.Collections;

/// <summary>
/// Base Node class. All nodes inherit from ANode
/// </summary>
public abstract class ANode<T> {

    // What happens when this event is triggered
    protected UnityEvent<T> Trigger;

    /// <summary>
    /// Add delegate to be called when the node is triggered.
    /// 
    /// A UnityAction of type T means it accepts a method with the signature
    ///     void MyMethodName(T myArg) { ... }
    /// 
    /// E.g. a UnityAction of type string could be the following:
    /// 
    ///     public void PrintString(string myStr) { Debug.Log(myStr); }
    /// 
    /// </summary>
    /// <param name="action"></param>
    public void AcceptTrigger(UnityAction<T> action)
    {
        Trigger.AddListener(action);
    }

    /// <summary>
    /// Remove delegate to be called when the node is triggered.
    /// 
    /// A UnityAction of type T means it accepts a method with the signature
    ///     void MyMethodName(T myArg) { ... }
    /// 
    /// E.g. a UnityAction of type string could be the following:
    /// 
    ///     public void PrintString(string myStr) { Debug.Log(myStr); }
    /// 
    /// </summary>
    /// <param name="action"></param>
    public void RemoveTrigger(UnityAction<T> action)
    {
        Trigger.RemoveListener(action);
    }

    protected void TriggerNode(T arg)
    {
        Trigger.Invoke(arg);
    }
}
