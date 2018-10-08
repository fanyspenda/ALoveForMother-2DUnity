using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextDetector : MonoBehaviour {

	public GameObject key;
	public GameObject noKey;
	public GameObject yesKey;
	public GameObject hiddenDoor;
	public GameObject textBox;

	private bool carryingKey = false;

	void OnTriggerEnter2D(Collider2D hit)
	{
		if (hit.CompareTag("TextDetector") && carryingKey == false)
		{
			key.SetActive (true);
			noKey.SetActive (true);
			hiddenDoor.SetActive (true);
			textBox.SetActive (true);
		}

		if (hit.CompareTag ("Key")) {
			Destroy (hit.gameObject);
			carryingKey = true;
			noKey.SetActive (false);
			yesKey.SetActive (true);
			hiddenDoor.SetActive (false);
		}

		if(hit.CompareTag("TextOff")){
			textBox.SetActive (false);
		}

		if (hit.CompareTag ("NextScene")) {
			GetComponent<SaveAndLoad> ().save ();
			SceneManager.LoadScene ("gameScene2");
		}
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
