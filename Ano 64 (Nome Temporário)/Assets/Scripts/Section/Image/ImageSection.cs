using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageSection : Section {

    public override void SendObject() {
        base.SendObject();
        SectionManager.instance.ImageSection((ImageObject)sectionObject);
    }
    
}
