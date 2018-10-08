using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Transform target;
	public float smoothMov = 10f;
	public Vector3 offset;
	public Vector3 velocity = Vector3.zero;

	void LateUpdate(){
		Vector3 desiredPosition = target.position + offset;
		Vector3 smoothedPosition = Vector3.SmoothDamp (transform.position,
			desiredPosition, ref velocity, smoothMov);
		transform.position = smoothedPosition;
	}
}
