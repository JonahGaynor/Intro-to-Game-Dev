using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenPlatformAppear : MonoBehaviour {
	public SpriteRenderer sr;


	// Use this for initialization
	void Start () {
		sr = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			sr.sortingOrder = 5;
		} 
		if (Input.GetKeyUp (KeyCode.Space)) {
			sr.sortingOrder = 0;
		}
	}
}
