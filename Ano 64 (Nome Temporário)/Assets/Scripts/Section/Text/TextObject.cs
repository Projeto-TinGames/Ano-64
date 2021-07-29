using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Section/Text Section/TextObject")]
public class TextObject : ScriptableObject {
    [TextArea(3,10)]public string text;
    public List<TextOption> options = new List<TextOption>();
}
