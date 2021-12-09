using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "3dObject/Clickable/ApproachableObject")]
public class ApproachableObject : ClickableObject {
    public override void Execute(GameObject obj) {
        ApproachManager.selfInstance.ApproachCamera(obj);
    }
}
