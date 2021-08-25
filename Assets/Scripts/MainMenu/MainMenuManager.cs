using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuManager : SectionManager {
    public GameObject titulo;

    private void Start() {
        onSection = true;
    }

    public void NewGame() {
        SceneController.instance.Load(1);
    }

    private void Update() {
        if (Input.GetMouseButtonDown(0) && titulo.activeSelf) {
            titulo.SetActive(false);
            darken.SetActive(false);
            SetSection(false);
        }
    }

    public override void ImageSection(ImageObject imageObject) {
        throw new System.NotImplementedException();
    }

    public override void TextSection(TextObject textObject) {
        throw new System.NotImplementedException();
    }
    
}
