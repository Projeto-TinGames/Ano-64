using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SectionManager : MonoBehaviour {
    public static SectionManager instance;
    public GameObject section;

    [System.NonSerialized]public bool onSection;
    private int onSectionCounter;

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

    public virtual void EnterSection(SectionObject sectionObject) {
        section.SetActive(true);
        onSection = true;
        instance = this;
        ExecuteSection(sectionObject);
    }
    
    public abstract void ExecuteSection(SectionObject sectionObject);
        
    public virtual void ExitSection() {
        section.SetActive(false);
        onSectionCounter = 5;
    }

}