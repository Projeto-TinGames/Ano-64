using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class _TriggerManager : SectionManager {
    public static _TriggerManager selfInstance;
    
    public override void Awake() {
        base.Awake();
        if (selfInstance == null) {
            selfInstance = this;
        }
        else {
            Destroy(gameObject);
        }
    }

    public void ActivateSection(GameObject gameObject) {
        section = gameObject;
        section.SetActive(true);
        onSection = true;
    }

    public override void ExitSection() {
        base.ExitSection();
        section = null;
    }
}
