using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartScreenTextScript : MonoBehaviour {

	//public int targetSize = 2;
	float targetX = 1f;
	float targetY = 1f;
	public AudioClip selectSound;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.C)) {
			transform.localScale = new Vector3 (1.5f, 1.5f, 0);
			GetComponent<AudioSource> ().PlayOneShot (selectSound);

//		transform.localScale = new Vector3 ((targetSize - transform.localScale)*.1f, (targetSize - transform.localScale)*.1f, 0);
		}
		transform.localScale += new Vector3 ((targetX - transform.localScale.x)*.1f, (targetY - transform.localScale.y)*.1f, 0);


	}
}