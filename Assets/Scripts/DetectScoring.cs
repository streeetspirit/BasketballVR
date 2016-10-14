using UnityEngine;
using System.Collections;

public class DetectScoring : MonoBehaviour {

	public int points;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter (Collision collision) {
		ScoreKeep keeper = FindObjectOfType<ScoreKeep> ();
		keeper.IncrementScore (points);

	}
}
