using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSection : Section {
    
    public override void SendObject() {
        base.SendObject();
        SectionManager.instance.TextSection((TextObject)sectionObject);
    }

}
