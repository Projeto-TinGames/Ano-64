using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PenManager : SectionManager {
    public static PenManager selfInstance;
    public TextMeshProUGUI textBox;
    public GameObject options;
    private List<TextMeshProUGUI> textButtons = new List<TextMeshProUGUI>();

    public override void Awake() {
        base.Awake();
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

        PenObject penObject = (PenObject)sectionObject;

        textBox.text = penObject.text;

        for (int i = 0; i < penObject.options[0].values.Length; i++) {
			textButtons[i].text = "\t" + penObject.options[0].values[i];
        }
    }
}
