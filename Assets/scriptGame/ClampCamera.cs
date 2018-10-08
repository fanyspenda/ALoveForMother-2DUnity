using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClampCamera : MonoBehaviour {
	public Transform target;
	public float xMin = -1;
	public float xMax = 1;
	public float yMin = -1;
	public float yMax = 1;

	Transform t;

	void Awake(){
		t = transform;
	}

	void LateUpdate(){
		float x = Mathf.Clamp (target.position.x, xMin, xMax);
		float y = Mathf.Clamp (target.position.y, yMin, yMax);
		t.position = new Vector3 (x, y, t.position.z);
	}

}
