using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DirectToScene4 : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter2D(Collider2D hit){
		if (hit.CompareTag ("GoToScene4")) {
			GetComponent<SaveAndLoad> ().save ();
			SceneManager.LoadScene ("gameScene4");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
