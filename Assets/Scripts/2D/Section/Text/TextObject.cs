using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "2dObject/Section/TextObject")]
public class TextObject : SectionObject {
    [TextArea(3,10)]public string text;
    public List<TextOption> options = new List<TextOption>();

    public override void Execute(Transform transform = null) {
        TextManager.selfInstance.EnterSection(this);
    }
}
