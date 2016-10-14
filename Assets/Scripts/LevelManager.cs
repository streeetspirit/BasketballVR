using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	int currentInd;

	public float timeToNextLevel = 0.0f;

	// Use this for initialization
	void Start () {
		// Load scene
		currentInd = SceneManager.GetActiveScene().buildIndex;



	}
	
	// Update is called once per frame
	void Update () {
		
//		print ("Time Left " + timeToNextLevel);

		if (timeToNextLevel > 0) {
			timeToNextLevel -= Time.deltaTime;
			if (timeToNextLevel <= 0) {
				LoadLevel ();
			}
		}
	}

	public void LoadLevel () {
		SceneManager.LoadScene (currentInd + 1);
	}

	public void LoadPrevious () {
		SceneManager.LoadScene (currentInd - 1);
	}
}
