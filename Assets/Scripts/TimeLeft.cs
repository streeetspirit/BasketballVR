using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeLeft : MonoBehaviour {

	LevelManager levelManager;
	Text text;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
		levelManager = FindObjectOfType<LevelManager> ();

	}

	// Update is called once per frame
	void Update () {
		text.text = "Time Left: " + levelManager.timeToNextLevel;
	}
}