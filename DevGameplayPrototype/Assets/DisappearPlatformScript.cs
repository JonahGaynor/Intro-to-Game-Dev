using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearPlatformScript : MonoBehaviour {

	public bool disappearPlat = false;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (disappearPlat == true) {
			Destroy (gameObject);
		}
	}

	void OnCollisionEnter2D (Collision2D coll) {
		if (coll.gameObject.name == "RobotBoyRun00" && Input.GetKey (KeyCode.Space)) {
			disappearPlat = true;
		}
	}
}
