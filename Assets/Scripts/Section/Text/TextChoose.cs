using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextChoose : MonoBehaviour {
    private string text;
    private int cooldown;

    private void OnEnable() {
        cooldown = 5;
    }

    private void FixedUpdate() {
        if (cooldown > 0) {
            cooldown--;
        }
    }

    public void Choose() {
        if (cooldown <= 0) {
            text = GetComponentInChildren<TextMeshProUGUI>().text.Replace("\t","");
            SectionManager.instance.ExitSection();
            Debug.Log(text);
        }
    }
}
