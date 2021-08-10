using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public int difficulty;
    public int page;
    public string[] itemsFound;

    private void Awake() {
        transform.SetParent(null);
        DontDestroyOnLoad(gameObject);
    }

    private void Update() {
        if (Input.GetButtonDown("Load")) {
            Load();
        }

        if (Input.GetButtonDown("Save")) {
            Save();
        }
    }

    public void Load() {
        PlayerData data = SaveSystem.LoadPlayer();

        difficulty = data.difficulty;
        page = data.page;
        itemsFound = data.itemsFound;
    }

    public void Save() {
        SaveSystem.SavePlayer(this);
    }

}
