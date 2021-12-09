using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : SectionManager {
    private void Update() {
        if (Input.GetButtonDown("Options")) {
            if (SectionManager.instance.onSection) {
                SectionManager.instance.ExitSection();
            }
            ExecuteSection();
        }
    }

    public override void ExecuteSection(SectionObject sectionObject = null) {
        if (section != null) {
            onSection = !onSection;
            section.SetActive(onSection);
        }
        
        instance = this;
    }
}
