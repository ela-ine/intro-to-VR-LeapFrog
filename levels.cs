using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levels : MonoBehaviour {
	int currentIndex;

	// Use this for initialization
	void Start () {

		currentIndex = SceneManager.GetActiveScene().buildIndex;

	}
	
	// Update is called once per frame
	void Update () {

	}

	public void LoadNextScene () {
		SceneManager.LoadScene (currentIndex + 1);
	}

	public void Quit () {
		Application.Quit ();
	}
}
