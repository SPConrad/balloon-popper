﻿using UnityEngine;
using System.Collections;

public class scoreController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void displayScore(int score)
	{
		gameObject.guiText.text = score.ToString();
	}
}
