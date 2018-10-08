using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class CodingMixer : MonoBehaviour {

	public AudioMixerSnapshot snapshot;
	public float crossFade;

	void OnTriggerEnter2D(Collider2D colider){
		snapshot.TransitionTo (crossFade);
	}
}
