using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DataPersistence : MonoBehaviour
{
    public static DataPersistence Instance;

    public string playerName;

    public string maxPlayerName = string.Empty;
    public int maxPlayerScore;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(this);
    }

    public void LoadData()
    {

        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            HighScore data = JsonUtility.FromJson<HighScore>(json);

            maxPlayerName = data.maxPlayerName;
            maxPlayerScore = data.maxPlayerScore;
        }

    }

    public void SaveData()
    {
        HighScore data = new HighScore();
        data.maxPlayerName = maxPlayerName;
        data.maxPlayerScore = maxPlayerScore;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }
}

class HighScore
{
    public string maxPlayerName;
    public int maxPlayerScore;
}
