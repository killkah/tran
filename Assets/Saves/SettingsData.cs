using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class SettingsClass
{
    public int resolution;
    public bool windowsMode;
    public bool soundsAndMusic;
    public int language;
}
public class SettingsData : MonoBehaviour
{
    [SerializeField] private Dropdown resolution;
    [SerializeField] private Toggle windowsMode;
    [SerializeField] private Toggle soundsAndMusic;
    [SerializeField] private Dropdown language;

    [SerializeField] private AudioSettingsController audioSettings;

    public SettingsClass settings = new SettingsClass();
    private void Start()
    {
        LoadData();
    }

    public void SaveData()
    {
        settings.resolution = resolution.value;
        settings.windowsMode = windowsMode.isOn;
        settings.soundsAndMusic = soundsAndMusic.isOn;
        settings.language = language.value;

        switch (settings.resolution)
        {
            case 0:
                Screen.SetResolution(1280, 720, settings.windowsMode);
                break;
            case 1:
                Screen.SetResolution(1366, 768, settings.windowsMode);
                break;
            case 2:
                Screen.SetResolution(1600, 900, settings.windowsMode);
                break;
            case 3:
                Screen.SetResolution(1920, 1080, settings.windowsMode);
                break;
        }

        if(settings.soundsAndMusic == true)
        {
            PlayerPrefs.SetInt("Volume", 1);
        }
        else
        {
            PlayerPrefs.SetInt("Volume", 0);
        }

        audioSettings.SaveAudio();

        string data = JsonUtility.ToJson(settings);
        File.WriteAllText(Path.Combine(Application.streamingAssetsPath + "Settings.json"), data);

        
    }

    public void LoadData()
    {
        if (File.Exists(Application.streamingAssetsPath))
        {
            string json = File.ReadAllText(Application.streamingAssetsPath + "Settings.json");
            settings = JsonUtility.FromJson<SettingsClass>(json);

        }
        else
        {
            settings = new SettingsClass();
        }
        SaveData();

    }
}
