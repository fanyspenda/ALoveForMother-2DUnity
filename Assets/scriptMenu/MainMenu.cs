using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class MainMenu : MonoBehaviour {

	public Animator anim;
	public GameObject music;

	public void playGame(){
		DontDestroyOnLoad (music);

		SceneManager.LoadScene ("gameScene1");
	}

	public void quitGame(){
		Application.Quit ();
	}
}