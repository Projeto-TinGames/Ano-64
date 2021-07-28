using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum TiposElementos {Text,Choice}

[CreateAssetMenu(menuName = "Text Section/TextObject")]
public class TextObject : ScriptableObject {
    [TextArea(3,10)]public List<Text> textos = new List<Text>();
    public List<TextChoice> opcoes = new List<TextChoice>();

    [System.NonSerialized]public string[] tiposElementos = new string[]{"Text","Choice"};
    public TiposElementos[] ordemElementos;
}
