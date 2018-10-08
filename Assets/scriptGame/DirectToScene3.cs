using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DirectToScene3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter2D(Collider2D hit){
		if (hit.CompareTag ("GoScene3")) {
			GetComponent<SaveAndLoad> ().save ();
			SceneManager.LoadScene ("gameScene3");
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
