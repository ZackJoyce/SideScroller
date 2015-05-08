﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour 
{
	float s;


	Slider slider;
	
	void Start()
	{

		slider = GetComponent<Slider>();
		slider.value = SoundManager.instance.musicVolume;

	}
	
	void OnGUI()
	{
		s = slider.value;
		SoundManager.instance.ChangeMusicVolume(s);
	}
	
//	void ChangeVolume()
//	{
//		s = slider.value;
//		soundManager.ChangeMusicVolume(s);
//	}
}

