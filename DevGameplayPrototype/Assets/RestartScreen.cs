using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartScreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (Input.GetKeyUp (KeyCode.Space)) {
			Application.LoadLevel ("HomeScreen");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}


