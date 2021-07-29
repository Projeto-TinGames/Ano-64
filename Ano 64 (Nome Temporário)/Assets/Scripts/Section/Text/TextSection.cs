using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextSection : Section {

    public override void SendObject() {
        base.SendObject();
        SectionManager.instance.TextSection((TextObject)sectionObject);
    }

}
