using UnityEngine;
using System.Collections;

public class CameraRotation : MonoBehaviour {

	private Camera child;

	// Use this for initialization
	void Start () {
		child = GetComponentInChildren<Camera> ();
		print (child);
	}
	
	// Update is called once per frame
	void Update () {
		float speed = 5.0f;
		float mouseX = Input.GetAxis ("Mouse X")*speed;
		float mouseY = Input.GetAxis ("Mouse Y")*speed;
		transform.localRotation = Quaternion.Euler(0, mouseX, 0) * transform.localRotation;
		child.transform.localRotation = Quaternion.Euler(-mouseY, 0, 0) * child.transform.localRotation;
	}
}
