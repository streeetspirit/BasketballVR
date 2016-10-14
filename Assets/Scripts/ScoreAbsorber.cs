using UnityEngine;
using System.Collections;

public class ScoreAbsorber : MonoBehaviour {

	public int score = 1;
	// Use this for initialization
	void Start () {
		ScoreKeep oldKeeper = FindObjectOfType<ScoreKeep> ();
		if (oldKeeper) {
			score = oldKeeper.score;
			Destroy (oldKeeper.gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
