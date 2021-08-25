using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageSection : Section {

    public override void SendObject() {
        if (VerifyConditions()) {
            base.SendObject();
            SectionManager.instance.ImageSection((ImageObject)sectionObject);
        }
    }
    
}
