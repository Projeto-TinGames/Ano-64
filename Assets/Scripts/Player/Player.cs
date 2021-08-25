using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public static Player instance;

    public string chapter;
    public string timestamp;
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

    public void AddItem(string key) {
        itemsFound.Add(key);
    }

    public bool FindItem(string key) {
        return itemsFound.Contains(key);
    }

}
