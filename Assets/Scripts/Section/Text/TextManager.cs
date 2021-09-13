using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextManager : SectionManager {
    public TextMeshProUGUI textBox;
    public GameObject options;
    private List<TextMeshProUGUI> textButtons = new List<TextMeshProUGUI>();
    public static TextManager selfInstance;

    public override void Awake() {
        Button[] optionButtons = options.GetComponentsInChildren<Button>();
        foreach (Button button in optionButtons) {
            textButtons.Add(button.GetComponentInChildren<TextMeshProUGUI>());
        }
        #region Singleton
        base.Awake();
        if (selfInstance == null) {
            selfInstance = this;
        }
        else {
            Destroy(gameObject);
        }
        #endregion
    }

    public override void ExecuteSection(SectionObject sectionObject) {
        TextObject textObject = (TextObject) sectionObject;

        textBox.text = textObject.text;

        for (int i = 0; i < textObject.options.Count; i++) {
			textButtons[i].text = "\t" + textObject.options[i].text;
        }
    }

    public override void ExitSection() {
        base.ExitSection();
        CloseText();
    }

    public void CloseText() {
        textBox.text = "";
        for (int i = 0; i < textButtons.Count; i++) {
			textButtons[i].text = "";
        }
    }
}
