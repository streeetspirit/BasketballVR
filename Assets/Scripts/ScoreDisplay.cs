using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {

	Text text;

	ScoreKeep scoreKeeper;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
		scoreKeeper = FindObjectOfType<ScoreKeep> ();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Score: " + scoreKeeper.GetScore ();
	}
}
