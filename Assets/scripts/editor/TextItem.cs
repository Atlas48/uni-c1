using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TextItem")]
public class TextItem : ScriptableObject {
    [Tooltip("The text to store")] public List<string> text;
    [Tooltip("Output Unix-type line endings?")] public bool NixString;

    public string AllText {
        get {
            var a = "";
            if (NixString) {
                foreach (var i in text) {
                    a += i + "\n";
                }
            } else {
                foreach (var i in text) {
                    a += i + "\r\n";
                }
            }
            return a;
        }
        /*set {
            var delim = { '\r', '\n' };
            if (NixString) text = new List<string>(value.Split('\n'));
            else text = new List<string>(value.Split(delim));
        }*/
    }
}
