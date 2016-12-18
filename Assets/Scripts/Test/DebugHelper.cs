using UnityEngine;
using System.Collections;

public class DebugHelper : MonoBehaviour {

    public static string FormatText(string text, string color)
    {
        return "<color=" + color.ToLower() + ">" + text + "</color>";
    }
}
