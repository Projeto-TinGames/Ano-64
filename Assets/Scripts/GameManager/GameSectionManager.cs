using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSectionManager : SectionManager {
    public GameObject imageSection;
    public GameObject textSection;
    public GameObject zoomScene;
    public GameObject saveScene;
    public GameObject magnifier;

    private bool onZoom;

    private void Update() {
        if (Input.GetButtonDown("Options")) {
            darken.SetActive(!saveScene.activeSelf);
            onSection = !saveScene.activeSelf;
            saveScene.SetActive(!saveScene.activeSelf);
        }
    }

    private void ControlZoom(bool zoom, Transform transform) {
        ZoomManager.instance.ControlZoom(zoom, transform);
        zoomScene.SetActive(zoom);
        darken.SetActive(!zoom);
        magnifier.SetActive(!zoom);
        onZoom = zoom;
    }

    private void HideSections() {
        imageSection.SetActive(false);
        textSection.SetActive(false);
        TextManager.instance.CloseText();
    }

    public override void EnterSection(bool sectionBool, bool zoom, Transform transform) {
        base.EnterSection(sectionBool, zoom, transform);
        ControlZoom(zoom,transform);
        if (!onZoom) {
            darken.SetActive(sectionBool);
        }
        HideSections();
    }

    public override void ImageSection(ImageObject imageObject) {
        HideSections();
        imageSection.SetActive(true);
        ImageManager.instance.PresentImage(imageObject);
    }

    public override void TextSection(TextObject textObject) {
        HideSections();
        textSection.SetActive(true);
        TextManager.instance.PresentText(textObject);
    }
}
