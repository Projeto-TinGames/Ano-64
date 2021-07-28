using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectionManager : MonoBehaviour {
    public static SectionManager instance;
    [System.NonSerialized]public bool onSection;

    private void Awake() {
        if (instance == null) {
            instance = this;
        }
        else {
            Destroy(gameObject);
        }
    }

    public void SetSection(bool sectionBool) {
        onSection = sectionBool;
    }

    public void TextSection(TextObject text) {
        Debug.Log(text);
    }

}
