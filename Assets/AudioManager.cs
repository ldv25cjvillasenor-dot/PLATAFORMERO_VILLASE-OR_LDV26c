using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public AudioMixer mixer;

    public void SetMaster(float value)
    {
        if (value <= 0.0001f)
            value = 0.0001f;

        mixer.SetFloat("MasterVolume", Mathf.Log10(value) * 20);
    }

    public void SetMusic(float value)
    {
        if (value <= 0.0001f)
            value = 0.0001f;

        mixer.SetFloat("MusicVolume", Mathf.Log10(value) * 20);
    }

    public void SetSFX(float value)
    {
        if (value <= 0.0001f)
            value = 0.0001f;

        mixer.SetFloat("SFXVolume", Mathf.Log10(value) * 20);
    }
}
