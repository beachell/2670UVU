using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class PlayerDataScript {

    PlayerDataScript() {

    }

    public int Score;
    public int Health;
    public Vector3 SpawnPoint;

    public static PlayerDataScript _instance;
    public static readonly string playerPrefsIdentifier;

    public static PlayerDataScript Instance {
        get {
            if (_instance == null)
            {
                PlayerDataScript.GetPlayerPrefs();

            }
            return _instance;
        }
    }

    public static void GetPlayerPrefs()
    {
        if (string.IsNullOrEmpty(PlayerPrefs.GetString(playerPrefsIdentifier)))
        {
            _instance = new PlayerDataScript();
        }
        else
        {
            _instance = JsonUtility.FromJson<PlayerDataScript>(PlayerPrefs.GetString(playerPrefsIdentifier));
        }
    }
    public static void SetPlayerPrefs() {
        PlayerPrefs.SetString(playerPrefsIdentifier, JsonUtility.ToJson(_instance));
    }

    public void SaveData() {
        string gameDataAsJson = JsonUtility.ToJson(this);
        PlayerPrefs.SetString(playerPrefsIdentifier, gameDataAsJson);
    }

    public static implicit operator PlayerDataScript(int v)
    {
        throw new NotImplementedException();
    }
}
