using System.IO;
using UnityEngine;

[System.Serializable]
public class Data
{
    public int coins;
}
public class CoinsData : MonoBehaviour
{
    public Data coinsData = new Data();

    private void Start()
    {
        LoadData();
    }

    public void SaveData()
    {
        string data = JsonUtility.ToJson(coinsData);
        File.WriteAllText(Path.Combine(Application.streamingAssetsPath + "Settings.json"), data);
    }

    public void ChangeData(int value)
    {
        coinsData.coins += value;
        SaveData();
    }

    public int GetData()
    {
        return coinsData.coins;
    }
    public void LoadData()
    {
        if (File.Exists(Application.streamingAssetsPath))
        {
            string json = File.ReadAllText(Application.streamingAssetsPath + "Settings.json");
            coinsData = JsonUtility.FromJson<Data>(json);
        }
        else
        {
            coinsData.coins = 0;
        }
        

    }
}
