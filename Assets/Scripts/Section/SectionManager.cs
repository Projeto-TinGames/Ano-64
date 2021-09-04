using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SectionManager : MonoBehaviour {
    public static SectionManager instance;

    [System.NonSerialized]public bool onSection;
    private int onSectionCounter;

    public GameObject canvas;
    public GameObject darken;
    public GameObject saveScene;

    public virtual void Awake() {
        instance = this;
    }

    public virtual void FixedUpdate() {
        if (onSectionCounter > 0) {
            onSectionCounter--;
            if (onSectionCounter <= 0) {
                onSection = false;
            }
        }
    }

    public void SetSection(bool sectionBool) {
        if (sectionBool) {
            onSection = sectionBool;
        }
        else {
            onSectionCounter = 5;
        }
    }

    public virtual void EnterSection(bool sectionBool, bool zoom, Transform transform) {
        SetSection(sectionBool);
    }

    public abstract void ToggleSave();

    public abstract void ImageSection(ImageObject imageObject);

    public abstract void TextSection(TextObject textObject);

}