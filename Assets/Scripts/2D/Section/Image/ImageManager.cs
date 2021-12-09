using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ImageManager : SectionManager {
    public Image image;
    public TextMeshProUGUI descriptionBox;
    private List<TextMeshProUGUI> textButtons = new List<TextMeshProUGUI>();

    #region Singleton
    public static ImageManager selfInstance;
    public override void Awake() {
        base.Awake();

        if (selfInstance == null) {
            selfInstance = this;
        }
        else {
            Destroy(gameObject);
        }
    }
    #endregion

    public override void ExecuteSection(SectionObject sectionObject) {
        ImageObject imageObject = (ImageObject)sectionObject;
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