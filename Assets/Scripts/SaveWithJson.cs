using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveWithJson : MonoBehaviour
{
    PlayerData _playerData = new PlayerData();
    //How to Save Data with Json
    void WritePlayerDataWithJson()
    {
        string jsonData = JsonUtility.ToJson(_playerData);
        PlayerPrefs.SetString("PlayerData", jsonData);
    }

    void ReadPlayerDataWithJson()
    {
        string jsonFromPrefs = PlayerPrefs.GetString("PlayerData");
        _playerData = JsonUtility.FromJson<PlayerData>(jsonFromPrefs);
    }

}

public class PlayerData
{
    public int level;
    public string name;
    public string description;
    public int money;
}
