using UnityEngine;
using UnityEngine.UI;

public class SettingsController : MonoBehaviour
{
    [SerializeField] private Dropdown resolution;
    [SerializeField] private Toggle windownMode;
    [SerializeField] private Toggle soundsAndMusic;
    [SerializeField] private Dropdown language;

    [SerializeField] private CurrentSettingsDataScript currentSettings;
    [SerializeField] private DefaultSettingsDataScript defaultSettings;

    [SerializeField] private AudioSettingsController audioSettings;

    public void SaveSettings()
    {
        currentSettings.resolution = resolution.value;
        currentSettings.windowsMode = windownMode.isOn;
        currentSettings.soundsAndMusic = soundsAndMusic.isOn;
        currentSettings.language = language.value;

        switch(currentSettings.resolution)
        {
            case 0:
                Screen.SetResolution(1280, 720, currentSettings.windowsMode);
                break;
            case 1:
                Screen.SetResolution(1366, 768, currentSettings.windowsMode);
                break;
            case 2:
                Screen.SetResolution(1600, 900, currentSettings.windowsMode);
                break;
            case 3:
                Screen.SetResolution(1920, 1080, currentSettings.windowsMode);
                break;
        }

        if(currentSettings.soundsAndMusic == true)
        {
            PlayerPrefs.SetInt("Volume", 1);
        }
        else
        {
            PlayerPrefs.SetInt("Volume", 0);
        }

        audioSettings.SaveAudio();
    }

    public void ResetSettings()
    {
        resolution.value = defaultSettings.resolution;
        windownMode.isOn = defaultSettings.windowsMode;
        soundsAndMusic.isOn = defaultSettings.soundsAndMusic;
        language.value = defaultSettings.language;

        SaveSettings();
    }
}
