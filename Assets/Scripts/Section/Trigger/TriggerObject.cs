using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Section/TriggerObject")]
public class TriggerObject : SectionObject {
    public string function;
    
    public override void Execute(Transform transform = null) {
        _TriggerManager.selfInstance.EnterSection(this);
    }
}
