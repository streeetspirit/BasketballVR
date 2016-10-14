using UnityEngine;
using System.Collections;

public class ScoreKeep : MonoBehaviour {

	public int score;


	// Use this for initialization
	void Start () {
		score = 0;
		DontDestroyOnLoad (gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void IncrementScore (int points) {
		score += points;
		print (score);
	}

	public string GetScore () {
		return score.ToString();
	}

}
