using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOverScore : MonoBehaviour {

	Text text;
	ScoreAbsorber absorber;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
		absorber = FindObjectOfType<ScoreAbsorber> ();

	}

	void Update () {
		text.text = "Your score is " + absorber.score;
	}

}
