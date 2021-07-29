using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageSection : MonoBehaviour {
    public ImageObject imageObject;

    public void SendImage() {
        SectionManager.instance.SetSection(true);
        SectionManager.instance.ImageSection(imageObject);
    }
}
