using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScaleScript : MonoBehaviour {

	float targetX = 5;
	float targetY = 9.75f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.localScale += new Vector3 ((targetX - transform.localScale.x)*.1f, (targetY - transform.localScale.y)*.1f, 0);
	}

	void OnCollisionEnter2D (Collision2D other) {
		if (transform.localScale.x < targetX + 0.2f) {
			transform.localScale += new Vector3 (10f, 19.50f, 0f);
		}
	}
}
