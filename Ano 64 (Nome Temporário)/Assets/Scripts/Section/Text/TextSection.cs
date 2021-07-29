using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextSection : MonoBehaviour {
    public TextObject textObject;

    public void SendText() {
        SectionManager.instance.SetSection(true);
        SectionManager.instance.TextSection(textObject);
    }
}
