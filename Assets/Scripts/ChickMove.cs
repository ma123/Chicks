using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickMove : MonoBehaviour {
	public float rotationSpeed;
	public float movementSpeed;
	public float rotationTime;

	public bool turn = false; 

	void Start() {
		Invoke("ChangeRotation",rotationTime);
	}

	void ChangeRotation() {
		if(Random.value > 0.5f)  {
			rotationSpeed = -rotationSpeed;
		}
		Invoke("ChangeRotation",rotationTime);
	}

	void Update() {
		transform.Rotate (new Vector3 (0, 0, rotationSpeed * Time.deltaTime));
	
		if (!turn) {
			transform.position += transform.up*movementSpeed*Time.deltaTime;
		} else {
			transform.position -= transform.up*movementSpeed*Time.deltaTime;
		}
	} 

	void OnCollisionEnter2D(Collision2D coll) {
		if (turn) {
			turn = false;
		} else {
			turn = true;			
		}
	}
}