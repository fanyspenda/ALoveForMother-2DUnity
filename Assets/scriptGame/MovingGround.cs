using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingGround : MonoBehaviour {

	public GameObject player;
	public GameObject ground;
	//private bool isGround = false;

	void OnCollisionEnter2D(Collision2D hit){
		if (hit.gameObject.tag == "Player") {
			player.transform.parent = ground.transform;
			//isGround = true;
		}
	}

	void OnCollisionExit2D(Collision2D hit){
		player.transform.parent = null;
	}
	void Update(){
		
	}
}