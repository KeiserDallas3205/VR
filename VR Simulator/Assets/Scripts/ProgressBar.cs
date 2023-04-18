using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ProgressBar : MonoBehaviour
{
	// References the slider
	public Slider slider;
	
		
	public void UpdateSlider(int amount)
	{
		if(slider.value + amount > slider.maxValue)
		{
			slider.value = slider.maxValue;
		}else
		{
		slider.value += amount;
		}
	}
}
