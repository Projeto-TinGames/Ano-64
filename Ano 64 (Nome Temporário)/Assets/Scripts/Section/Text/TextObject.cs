using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public enum Alignment {Left,Center};

[CreateAssetMenu(menuName = "Section/Text Section/TextObject")]
public class TextObject : SectionObject {
    [TextArea(3,10)]public string text;
    public TextAlignmentOptions alignment = TextAlignmentOptions.Justified;
    public List<TextOption> options = new List<TextOption>();
}
