using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SaveSlot : MonoBehaviour {
    public int slotNumber;

    public TextMeshProUGUI chapter;
    public TextMeshProUGUI timestamp;
    public TextMeshProUGUI iconText;
    public Image icon;

    private void OnEnable() {
        PlayerData data = SaveSystem.LoadPlayer(slotNumber);

        if (data != null) {
            chapter.text = data.chapter;
            timestamp.text = data.timestamp;
            iconText.text = data.chapter;
        }

        else {
            iconText.text = "Vazio";
            chapter.text = "Vazio";
        }
    }

    public void Save() {
        SaveSystem.SavePlayer(slotNumber, Player.instance);
        SectionManager.instance.ExitSection();
    } 

    public void Load() {
        PlayerData data = SaveSystem.LoadPlayer(slotNumber);

        if (data != null) {
            Player.instance.chapter = data.chapter;
            Player.instance.difficulty = data.difficulty;
            Player.instance.page = data.page;
            Player.instance.itemsFound = new List<string>(data.itemsFound);
            SceneController.instance.Load(data.page);
        }
        SectionManager.instance.ExitSection();
    }
}
