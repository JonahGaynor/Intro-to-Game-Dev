using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScreen : MonoBehaviour {

	bool haveSeenKeyUp = false;
	bool singleFramePassed = false;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (!singleFramePassed) {
			singleFramePassed = true;
			return;
		}
		if (!Input.GetKey (KeyCode.Space)) {
			haveSeenKeyUp = true;
			Debug.Log ("AAAAAAH");
		}
		else if (Input.GetKeyDown (KeyCode.Space) && haveSeenKeyUp==true) {
			SceneManager.LoadScene ("HomeScreen");
			Debug.Log ("FRAMES UP");
		
		}
	}
}


