using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dead2 : MonoBehaviour {

	public GameObject PlayerWalkerKiller;
	public AudioSource myFx;
	public AudioClip DeadFx;
	public GameObject Transition;

	Animator anim;

	void Start(){
		anim = GetComponent<Animator>();
	}
	public void deadSound (){
		myFx.PlayOneShot (DeadFx);
	}


	void OnTriggerEnter2D(Collider2D hit){
		if(hit.CompareTag("Killer")){
			PlayerWalkerKiller.GetComponent<PlayerControl> ().enabled = false;
			anim.SetBool ("Dead", true);
			Transition.SetActive (true);
			deadSound ();
		}
	}

	public void Continue(){
		SceneManager.LoadScene ("gameScene4");
	}

	public void GiveUp(){
		SceneManager.LoadScene ("mainMenu");
	}
}
