using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextManager : MonoBehaviour {
    public static TextManager instance;
    public TextMeshProUGUI textBox;
    public GameObject options;
    private List<TextMeshProUGUI> textButtons = new List<TextMeshProUGUI>();

    private void Awake() {
        if (instance == null) {
            instance = this;
        }
        else {
            Destroy(gameObject);
        }
    }

    private void Start() {
        Button[] optionButtons = options.GetComponentsInChildren<Button>();
        foreach (Button button in optionButtons) {
            textButtons.Add(button.GetComponentInChildren<TextMeshProUGUI>());
        }
    }

    public void PresentText(TextObject textObject) {
        textBox.text = textObject.text;
        textBox.alignment = textObject.alignment;
        for (int i = 0; i < textObject.options.Count; i++) {
			textButtons[i].text = "\t" + textObject.options[i].text;
        }
    }

    public void CloseText() {
        textBox.text = "";
        for (int i = 0; i < textButtons.Count; i++) {
			textButtons[i].text = "";
        }
    }
}
