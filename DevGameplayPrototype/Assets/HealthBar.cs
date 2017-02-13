using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			transform.localScale = new Vector3 (transform.localScale.x - 0.1f, 1, 1);
		}
		else if (transform.localScale.x < 5) {
			transform.localScale = new Vector3 (transform.localScale.x + 0.1f, 1, 1);
		}


	}
}
