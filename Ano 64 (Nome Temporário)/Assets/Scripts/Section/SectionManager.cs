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
    public GameObject darken;
    public GameObject zoomScene;
    public GameObject magnifier;

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

    public void SetSection(bool sectionBool, bool zoom, Transform transform) {
        if (sectionBool) {
            onSection = sectionBool;
        }
        else {
            onSectionCounter = 5;
        }
        canvas.SetActive(sectionBool);
        ControlZoom(zoom,transform);
        HideSections();
    }

    private void HideSections() {
        imageSection.SetActive(false);
        textSection.SetActive(false);
        TextManager.instance.CloseText();
    }

    private void ControlZoom(bool zoom, Transform transform) {
        ZoomManager.instance.ControlZoom(zoom, transform);
        zoomScene.SetActive(zoom);
        darken.SetActive(!zoom);
        magnifier.SetActive(!zoom);
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
