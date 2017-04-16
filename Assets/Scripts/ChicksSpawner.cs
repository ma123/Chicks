using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChicksSpawner : MonoBehaviour {
	public float objectsMinX;
	public float objectsMaxX;
	public float objectsMinY;
	public float objectsMaxY;

	float chickPrice = 10.0f;
	public Text scoreText;
	public Button addChick;
	public GameObject chick;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (ChicksCounter.score >= chickPrice) {
			addChick.interactable = true;
		} else {
			addChick.interactable = false;
		}
	}

	public void AddChick() {
		if(ChicksCounter.score >= chickPrice) {
			ChicksCounter.score -= chickPrice; 
			scoreText.text = " " + ChicksCounter.score + " ";
			chickPrice *= 1.5f;

			GameObject obj = (GameObject)Instantiate(chick);
			float randomX = UnityEngine.Random.Range(objectsMinX, objectsMaxX);
			float randomY = UnityEngine.Random.Range(objectsMinY, objectsMaxY);
			obj.transform.position = new Vector3(randomX, randomY,0);   
		}
	}
}
