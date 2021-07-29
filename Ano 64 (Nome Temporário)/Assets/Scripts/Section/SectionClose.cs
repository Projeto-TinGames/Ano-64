using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectionClose : MonoBehaviour {
    public Transform transform;

    public void Close() {
        SectionManager.instance.SetSection(false);
        ZoomManager.instance.ZoomOut(transform);
    }
    
}
