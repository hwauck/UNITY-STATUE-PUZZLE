﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class pregameSurvey : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public void loadGame() {
		// save gender, age, game experience, repeated plays to resultStr/database
		SceneManager.LoadScene("puzzle");

	}

	// Update is called once per frame
	void Update () {
	
	}
}
