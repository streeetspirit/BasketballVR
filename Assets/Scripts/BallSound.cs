﻿using UnityEngine;
using System.Collections;

public class BallSound : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter (Collision collision) {
		AudioSource source = GetComponent<AudioSource> ();
		source.Play ();
	}
}
