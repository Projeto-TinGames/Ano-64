using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Section/Image Section/ImageObject")]
public class ImageObject : ScriptableObject {
    public Sprite sprite;
    public bool useDimensions;
    public float width;
    public float height;
    [TextArea(3,10)]public string description;
}
