using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlusOne : MonoBehaviour {

	// Use this for initialization
	void Start () {
			Destroy(gameObject, 1); // znicenie naboja po 2 sekundach ak nenajde ciel
	}
}
