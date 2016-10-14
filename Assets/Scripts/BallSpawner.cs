using UnityEngine;
using System.Collections;

public class BallSpawner : MonoBehaviour {

	public GameObject ballPrefab;
	public float velocity = 5.0f;
	private Camera camera;

	// Use this for initialization
	void Start () {
		camera = GetComponent<Camera> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			BallLaunch ();
		}
	}

	void BallLaunch () {
		GameObject instance = Instantiate (ballPrefab);
		Rigidbody rb = instance.GetComponent<Rigidbody> ();
		instance.transform.position = transform.position;

		rb.velocity = camera.transform.rotation * Vector3.forward * velocity;
	}
}
