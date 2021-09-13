using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Section/ZoomObject")]
public class ZoomObject : SectionObject {
    public string text;
    [System.NonSerialized]public Transform transform;
    
    public override void Execute(Transform transform) {
        this.transform = transform;
        ZoomManager.selfInstance.EnterSection(this);
    }
}
