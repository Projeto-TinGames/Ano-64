using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextChoose : MonoBehaviour {
    private string text;

    private void Start() {
        text = GetComponentInChildren<TextMeshProUGUI>().text.Replace("\t","");
    }

    public void Choose() {
        SectionManager.instance.SetSection(false);
        Debug.Log(text);
    }
}
