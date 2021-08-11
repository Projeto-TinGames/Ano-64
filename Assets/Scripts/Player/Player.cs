using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public static Player instance;

    public int difficulty;
    public int page;
    public List<string> itemsFound = new List<string>();

    private void Awake() {
        if (instance == null) {
            instance = this;
            transform.SetParent(null);
            DontDestroyOnLoad(gameObject);
        }
        else {
            Destroy(gameObject);
        }
    }

    private void Update() {
        if (Input.GetButtonDown("Load")) {
            Load();
        }

        if (Input.GetButtonDown("Save")) {
            Save();
        }
    }

    public void AddItem(string key) {
        itemsFound.Add(key);
    }

    public bool FindItem(string key) {
        return itemsFound.Contains(key);
    }

    public void Load() {
        PlayerData data = SaveSystem.LoadPlayer();

        difficulty = data.difficulty;
        page = data.page;
        itemsFound = new List<string>(data.itemsFound);
    }

    public void Save() {
        SaveSystem.SavePlayer(this);
    }

}
