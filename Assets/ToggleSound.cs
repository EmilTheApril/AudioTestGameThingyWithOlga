using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSound : MonoBehaviour
{
    [SerializeField] private bool _toggleEffects, _toggleMusic;

    public void Toggle()
    {
        if (_toggleEffects) SoundManager.instance.ToggleEffects();
        if(_toggleMusic) SoundManager.instance.ToggleMusic();
    }
}
