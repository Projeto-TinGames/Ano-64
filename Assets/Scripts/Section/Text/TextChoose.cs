using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextChoose : MonoBehaviour {
    private string text;

    public void Choose() {
        text = GetComponentInChildren<TextMeshProUGUI>().text.Replace("\t","");
        SectionManager.instance.ExitSection();
        Debug.Log(text);
    }
}
