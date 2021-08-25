using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuManager : SectionManager {
    public GameObject titulo;

    public void NovoJogo() {
        SceneController.instance.Load(1);
    }

    public void CarregarJogo() {
        Debug.Log("Carregar");
    }

    private void Update() {
        if (Input.GetMouseButtonDown(0) && titulo.activeSelf) {
            titulo.SetActive(false);
            darken.SetActive(false);
        }
    }

    public override void ImageSection(ImageObject imageObject) {
        throw new System.NotImplementedException();
    }

    public override void TextSection(TextObject textObject) {
        throw new System.NotImplementedException();
    }
    
}
