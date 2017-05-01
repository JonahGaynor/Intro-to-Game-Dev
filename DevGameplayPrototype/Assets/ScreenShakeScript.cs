using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShakeScript : MonoBehaviour {

	float counter = 10;
	float mag = .01f;
	float xPos;
	float yPos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			float xPos = Random.Range(9.6f - mag, 9.6f + mag);
			float yPos = Random.Range(transform.position.y - mag, transform.position.y + mag);
					

			if (counter > 0) {
			transform.position = new Vector3 (xPos, yPos, 0);
			counter -= Time.deltaTime;
			mag = mag + .01f;
			}
		}
		if (Input.GetKeyUp (KeyCode.Space)) {
			transform.position = new Vector3 (9.6f, transform.position.y, 0);
			mag = .01f;
		}
	}
}
