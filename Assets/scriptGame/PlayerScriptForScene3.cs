using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScriptForScene3 : MonoBehaviour {

	public GameObject Text1;
	public GameObject BrainIcon;
	public GameObject HeartIcon;

	void OnTriggerEnter2D(Collider2D hit){
		if(hit.CompareTag("TextDetector")){
			Text1.SetActive (true);		
		}

		if (hit.CompareTag ("TextOff")) {
			Text1.SetActive (false);
		}

		if(hit.CompareTag("BrainOn")){
			Destroy (hit.gameObject);
			BrainIcon.SetActive (true);
		}

		if(hit.CompareTag("HeartOn")){
			Destroy (hit.gameObject);
			HeartIcon.SetActive (true);
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
