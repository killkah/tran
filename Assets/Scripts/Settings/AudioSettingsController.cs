using UnityEngine;
using UnityEngine.Audio;

public class AudioSettingsController : MonoBehaviour
{
    [SerializeField] private AudioMixer mixer;

    public void SaveAudio()
    {
        int volume = PlayerPrefs.GetInt("Volume");

        if (volume == 0)
        {
            mixer.SetFloat("MasterVolume", -80);
        }
        else if (volume == 1)
        {
            mixer.SetFloat("MasterVolume", 20);
        }
    }
}
