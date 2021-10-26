using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    [SerializeField]
	AudioMixer mixer;
	//[SerializeField]
	//Slider slider;

	//// Start is called before the first frame update
	//void Awake()
	//{
	//    slider.value = PlayerPrefs.GetFloat(slider.name);
	//    Debug.Log($"{slider.name} : {PlayerPrefs.GetFloat(slider.name, 0f)}");
	//}

	private void Awake()
	{
		Slider[] sliders = FindObjectsOfType<Slider>(true);
		foreach (Slider slider in sliders)
		{
			float value = PlayerPrefs.GetFloat(slider.name);
			slider.value = value;
			Debug.Log($"{slider.name} : {value}");
		}
	}
}
