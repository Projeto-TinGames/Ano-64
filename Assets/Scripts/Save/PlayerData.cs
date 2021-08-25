using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData {

    public string chapter;
    public string timestamp;
    public int difficulty;
    public int page;
    public string[] itemsFound;

    public PlayerData(Player player) {
        chapter = player.chapter;
        timestamp = player.timestamp;
        difficulty = player.difficulty;
        page = player.page;
        itemsFound = player.itemsFound.ToArray();
    }

}