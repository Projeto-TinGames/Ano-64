using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordNavigation : MonoBehaviour {
    public void NavigateWord(int offset) {
        PenManager.selfInstance.ExecuteWord(offset);
    }
}
