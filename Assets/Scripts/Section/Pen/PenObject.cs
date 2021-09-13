using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Options {
    public string[] values = new string[9];
}

[CreateAssetMenu(menuName = "Section/PenObject")]
public class PenObject : SectionObject {
    public string text;
    public List<Options> options = new List<Options>();
    
    public override void Execute(Transform transform = null) {
        PenManager.selfInstance.EnterSection(this);
    }
}