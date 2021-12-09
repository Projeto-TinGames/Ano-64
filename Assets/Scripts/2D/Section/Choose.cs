using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Choose : MonoBehaviour {
    private string text;

    public void ChooseOption() {
        text = GetComponentInChildren<TextMeshProUGUI>().text.Replace("\t","");
        SectionManager.instance.HandleChoice(text);
    }
}
