using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Section : MonoBehaviour {
    public SectionObject sectionObject;

    public bool VerifyConditions() {
        if (sectionObject.zoom && !Player.instance.FindItem("Magnifier")) {
            return false;
        }
        return true;
    }
    
    public virtual void SendObject() {
        SectionManager.instance.EnterSection(true,sectionObject.zoom,transform);
    }
}