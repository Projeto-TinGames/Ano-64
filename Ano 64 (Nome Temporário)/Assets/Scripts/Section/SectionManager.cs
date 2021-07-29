using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectionManager : MonoBehaviour {
    public static SectionManager instance;
    [System.NonSerialized]public bool onSection;
    private int onSectionCounter;

    public GameObject canvas;
    public GameObject imageSection;
    public GameObject textSection;

    private void Awake() {
        if (instance == null) {
            instance = this;
        }
        else {
            Destroy(gameObject);
        }
    }

    private void FixedUpdate() {
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
        canvas.SetActive(sectionBool);
        HideSections();
    }

    private void HideSections() {
        imageSection.SetActive(false);
        textSection.SetActive(false);
    }

    public void ImageSection(ImageObject imageObject) {
        HideSections();
        imageSection.SetActive(true);
        ImageManager.instance.PresentImage(imageObject);
    }

    public void TextSection(TextObject textObject) {
        textSection.SetActive(true);
        TextManager.instance.PresentText(textObject);
    }

}
