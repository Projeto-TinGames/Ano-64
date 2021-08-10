using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Section : MonoBehaviour {
    public SectionObject sectionObject;
    
    public virtual void SendObject() {
        SectionManager.instance.SetSection(true,sectionObject.zoom,transform);
    }
}