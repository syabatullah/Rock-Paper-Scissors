using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
	public Sprite[] spriteMute;
	public Button buttonMute;
	public Toggle toggleonMute;
	public AudioSource BackSound;

	public Slider sliderVolume;
	// Start is called before the first frame update
    void Start()
    {
		if(Sound.Instance.music.mute == true)
		{
			buttonMute.image.sprite = spriteMute[1];
		}
		else
		{
			buttonMute.image.sprite=spriteMute[0];
		}

		sliderVolume.value= Sound.Instance.music.volume;
    }

    // Update is called once per frame
    void Update()
    {
		
    }

	public void SliderVolume()
	{
		Sound.Instance.music.volume = sliderVolume.value;

		if(sliderVolume.value <= sliderVolume.minValue)
		{
			Sound.Instance.music.mute = true;
		}
		else
		{
			Sound.Instance.music.mute = false;
		}
	}



	public void ButtonInGame()
	{
		SceneManager.LoadScene(1);
	}

	public void ButtonMute()
	{
	   Sound.Instance.MuteSound();

	if(Sound.Instance.music.mute == true)
	 {
		buttonMute.image.sprite = spriteMute[1];
	 }
	 else
	 {
		buttonMute.image.sprite=spriteMute[0];
	 }
	}


	public void TogglenMute()
	{
		Sound.Instance.MuteSound();

		if(Sound.Instance.music.mute == true)
		{
			toggleonMute.isOn= false;
		}
		else
		{
			toggleonMute.isOn = true;
		}
	}
}
