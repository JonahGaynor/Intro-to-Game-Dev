using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearPlatformScript : MonoBehaviour {

	public bool disappearPlat = false;
	bool triggerDisappear = false;
	Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (disappearPlat == true) {
		//	Destroy (gameObject);
		}
		if (triggerDisappear == true) {
			rb2d.bodyType = RigidbodyType2D.Dynamic;
		}

	}

	void OnCollisionEnter2D (Collision2D coll) {
		//if (coll.gameObject.name == "RobotBoyRun00" && Input.GetKey (KeyCode.Space)) {
		//Destroy (gameObject);

		if (coll.gameObject.name != "RobotBoyRun00") {
			Destroy (gameObject);
		}

		triggerDisappear = true;


		disappearPlat = true;
		//}
	}
}
