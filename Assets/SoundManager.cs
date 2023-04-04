using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    [SerializeField] private AudioSource _toggleMusic, _toggleEffects;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlayEffect(AudioClip clip)
    {
        _toggleEffects.PlayOneShot(clip);
    }

    public void SliderVolume(float value)
    {
        AudioListener.volume = value;
    }

    public void ToggleMusic()
    {
        _toggleMusic.mute = !_toggleMusic.mute;
    }

    public void ToggleEffects()
    {
        _toggleEffects.mute = !_toggleEffects.mute;
    }
}
