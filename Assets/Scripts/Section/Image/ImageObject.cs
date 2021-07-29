using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Section/Image Section/ImageObject")]
public class ImageObject : SectionObject {
    public Sprite sprite;
    [TextArea(3,10)]public string description;
    public bool useDimensions;
    public float width;
    public float height;
}
