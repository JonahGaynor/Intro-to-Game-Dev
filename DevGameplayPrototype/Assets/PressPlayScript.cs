using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressPlayScript : MonoBehaviour {

	public int targetSize = 2;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
//			transform.localScale = new Vector3 ((targetSize - transform.localScale)*.1f, (targetSize - transform.localScale)*.1f, 0);
		}
		
	}
}
