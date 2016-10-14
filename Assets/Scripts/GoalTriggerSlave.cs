using UnityEngine;
using System.Collections;


public class GoalTriggerSlave : MonoBehaviour {

	ScoreKeep scoreKeeper;

	public int points;
	private Collider ballDetected;


	// Use this for initialization
	void Start () {
		scoreKeeper = FindObjectOfType<ScoreKeep> ();
	}


	public void ExpectCollider (Collider collider) {
		
		ballDetected = collider;

		print ("added to queue"+collider);
	}

	void OnTriggerEnter (Collider collider) {
		print ("Detected");
		if (ballDetected == collider) {
			print ("Match!!!!");
			scoreKeeper.IncrementScore (points);
			AudioSource source = GetComponent<AudioSource> ();
			source.Play ();

		}
	}
}
