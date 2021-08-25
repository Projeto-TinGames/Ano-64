using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem {
    
    public static void SavePlayer(int slot, Player player) {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player" + slot + ".save";

        FileStream fileStream = new FileStream(path, FileMode.Create);
        PlayerData data = new PlayerData(player);
        formatter.Serialize(fileStream, data);

        fileStream.Close();
    }

    public static PlayerData LoadPlayer(int slot) {
        string path = Application.persistentDataPath + "/player" + slot + ".save";

        if (File.Exists(path)) {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fileStream = new FileStream(path, FileMode.Open);

            PlayerData data = (PlayerData)binaryFormatter.Deserialize(fileStream);
            data.timestamp = File.GetLastWriteTime(path).ToString();
            fileStream.Close();

            return data;
        }

        else {
            //Debug.LogError("File not found in " + path);
            return null;
        }
    }

}
