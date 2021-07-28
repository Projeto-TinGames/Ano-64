using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextSection : MonoBehaviour {
    public TextObject text;

    public void SendText() {
        SectionManager.instance.TextSection(text);
    }
}
