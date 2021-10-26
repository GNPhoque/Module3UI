using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioSlider : MonoBehaviour
{
    [SerializeField]
    AudioMixer mixer;
    [SerializeField]
    Slider slider;

    public void ValueChanged(float value)
	{
        Debug.Log($"SET {slider.name} : {value}");
        mixer.SetFloat(slider.name, slider.value);
        PlayerPrefs.SetFloat(slider.name, value);
	}
}
