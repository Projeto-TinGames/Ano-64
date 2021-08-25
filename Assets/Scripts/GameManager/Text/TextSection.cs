using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextSection : Section {

    public override void SendObject() {
        if (VerifyConditions()) {
            base.SendObject();
            SectionManager.instance.TextSection((TextObject)sectionObject);
        }
    }
}
