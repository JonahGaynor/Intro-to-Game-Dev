using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressCreditsScript : MonoBehaviour {

	float targetX = 1f;
	float targetY = 1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.C)) {
			transform.localScale = new Vector3 (1.5f, 1.5f, 0);
			//transform.localScale = new Vector3 (2f, 2f, 0);
		}
		transform.localScale += new Vector3 ((targetX - transform.localScale.x)*.1f, (targetY - transform.localScale.y)*.1f, 0);

	}
}
