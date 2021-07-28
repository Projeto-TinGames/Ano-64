using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TextChoice : TextElement {
    public List<TextOption> opcoes = new List<TextOption>();

    public override void Execute() {
        Debug.Log("lel");
    }
}
