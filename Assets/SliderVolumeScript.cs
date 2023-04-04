using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderVolumeScript : MonoBehaviour
{
    [SerializeField] private Slider slider;

    private void Start()
    {
        SoundManager.instance.SliderVolume(slider.value);
        slider.onValueChanged.AddListener(val => SoundManager.instance.SliderVolume(val));
    }
}
