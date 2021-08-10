using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData {

    public int difficulty;
    public int page;
    public string[] itemsFound;

    public PlayerData(Player player) {
        difficulty = player.difficulty;
        page = player.page;
        itemsFound = player.itemsFound;
    }

}