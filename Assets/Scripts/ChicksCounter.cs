using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class ChicksCounter : MonoBehaviour {
	float rateConstant = 3f;
	float rateIndex = 0.0f;
	public static float score = 0.0f;
	public Text scoreText;
	public GameObject plusOne;

	public GameObject[] chicks;
	// Use this for initialization
	void Start () {
		InvokeRepeating("AddToScore", 1.0f, 1.0f);
	}
	
	// Update is called once per frame
	void Update () {
		chicks = GameObject.FindGameObjectsWithTag ("Chick");
		rateIndex = chicks.Length * rateConstant;

		if(Input.GetMouseButtonDown(0)) {
			Vector3 v = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			v.z = 20.0f;
			Instantiate(plusOne, v, Quaternion.identity);
			PlusOnePoint();
		}
	}

	void AddToScore() {
		score += rateIndex;
		scoreText.text = " " + Math.Round(score, 2) + " ";
	}

	void PlusOnePoint() {
		score += 1.0f;
		scoreText.text = " " + Math.Round(score, 2) + " ";
	}
}
