using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Word {
    public int textIndex;
    public string[] possibleValues = new string[9];
}

[CreateAssetMenu(menuName = "Section/PenObject")]
public class PenObject : SectionObject {
    [TextArea(3,10)]public string text;
    public List<Word> words = new List<Word>();
    public string[] answers;
    [System.NonSerialized]public string finalAnswer;
    
    public override void Execute(Transform transform = null) {
        PenManager.selfInstance.EnterSection(this);
    }
}