﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

	public Text timerText;

	public float totalTime;
	int seconds;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		totalTime -= Time.deltaTime;
		seconds = (int)totalTime;
		timerText.text = seconds.ToString ();
		if (totalTime <= 0) {
			SceneManager.LoadScene ("gameover");
		}
	}

}
