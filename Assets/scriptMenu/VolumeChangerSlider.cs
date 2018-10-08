using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class VolumeChangerSlider : MonoBehaviour {

	public AudioMixer masterMixer;
	public Slider sliderSFX;
	public Slider sliderMusic;

	void Update(){
		setMusicSound (sliderMusic.value);
		setSFXSound (sliderSFX.value);
	}

	public void setMusicSound(float soundLevel){
		masterMixer.SetFloat ("musicVol", soundLevel);
	}

	public void setSFXSound(float soundLevel){
		masterMixer.SetFloat ("sfxVol", soundLevel);
	}
}