using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ImageManager : MonoBehaviour {
    public static ImageManager instance;
    public Image image;
    public TextMeshProUGUI descriptionBox;
    private List<TextMeshProUGUI> textButtons = new List<TextMeshProUGUI>();

    private void Awake() {
        if (instance == null) {
            instance = this;
        }
        else {
            Destroy(gameObject);
        }
    }

    public void PresentImage(ImageObject imageObject) {
        image.sprite = imageObject.sprite;
        descriptionBox.text = imageObject.description;

        if (imageObject.useDimensions) {
            image.rectTransform.localScale = new Vector3(imageObject.width, imageObject.height, 0f);
        }
        else {
            image.rectTransform.localScale = new Vector3(1f, 1f, 0f);
        }
    }

}