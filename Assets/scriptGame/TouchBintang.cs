using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TouchBintang : MonoBehaviour {

	public Text SkorBintang;
	private int TotalBintang;

	void OnTriggerEnter2D(Collider2D hit){
		if (hit.CompareTag ("Star")) {
			TotalBintang++;
			UpdateSkor ();
			Destroy (hit.gameObject);
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (TotalBintang == 3) {
			SceneManager.LoadScene ("mainMenu");
		}
	}

	void UpdateSkor (){
		SkorBintang.text = "Bintang " + TotalBintang;
	}
}
