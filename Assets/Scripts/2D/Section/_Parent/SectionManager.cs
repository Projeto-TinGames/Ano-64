using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SectionManager : MonoBehaviour {
    public static SectionManager instance;
    public GameObject section;

    [System.NonSerialized]public bool onSection;
    private int cooldown;

    public virtual void Awake() {
        instance = this;
    }

    public virtual void FixedUpdate() {
        if (cooldown > 0) {
            cooldown--;
            if (cooldown <= 0) {
                onSection = false;
            }
        }
    }

    public virtual void EnterSection(SectionObject sectionObject) {
        if (section != null) {
            section.SetActive(true);
            onSection = true;
        }
        
        instance = this;
        ExecuteSection(sectionObject);
    }
    
    public virtual void ExecuteSection(SectionObject sectionObject) {

    }

    public virtual void HandleChoice(string text){}
        
    public virtual void ExitSection() {
        section.SetActive(false);
        cooldown = 5;
    }

}