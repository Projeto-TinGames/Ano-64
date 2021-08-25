using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SectionManager : MonoBehaviour {
    public static SectionManager instance;

    [System.NonSerialized]public bool onSection;
    private int onSectionCounter;

    public GameObject canvas;
    public GameObject darken;

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

    public virtual void SetSection(bool sectionBool, bool zoom, Transform transform) {
        if (sectionBool) {
            onSection = sectionBool;
        }
        else {
            onSectionCounter = 5;
        }
    }

    public abstract void ImageSection(ImageObject imageObject);

    public abstract void TextSection(TextObject textObject);

}