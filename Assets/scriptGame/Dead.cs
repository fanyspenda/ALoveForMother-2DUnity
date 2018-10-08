using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dead : MonoBehaviour {

	public GameObject PlayerWalkerKiller;
	public AudioSource myFx;
	public AudioClip DeadFx;
	public GameObject Transition;

	Animator anim;

	public void deadSound (){
		myFx.PlayOneShot (DeadFx);
	}


	void OnTriggerEnter2D(Collider2D hit){
		anim = GetComponent<Animator>();
		if(hit.CompareTag("Killer")){
			PlayerWalkerKiller.GetComponent<PlayerControl> ().enabled = false;
			anim.SetBool ("Dead", true);
			Transition.SetActive (true);
			deadSound ();
		}
	}

	public void Continue(){
		SceneManager.LoadScene ("gameScene2");
	}

	public void GiveUp(){
		SceneManager.LoadScene ("mainMenu");
	}
}
