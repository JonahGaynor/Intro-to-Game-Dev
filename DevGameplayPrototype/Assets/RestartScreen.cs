using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScreen : MonoBehaviour {

	bool haveSeenKeyUp = false;
	bool singleFramePassed = false;

	public AudioClip BLAM;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (!singleFramePassed) {
			singleFramePassed = true;
			return;
		}
		if (!Input.GetKeyUp (KeyCode.Space)) {
			haveSeenKeyUp = true;
		}
		if (Input.GetKeyDown (KeyCode.C)) {
			GetComponent<AudioSource>().PlayOneShot(BLAM);
		}
		if (Input.GetKeyUp (KeyCode.C) && haveSeenKeyUp == true) {
			SceneManager.LoadScene ("HomeScreen");
		
		}
	}
}

//&& haveSeenKeyUp==true
