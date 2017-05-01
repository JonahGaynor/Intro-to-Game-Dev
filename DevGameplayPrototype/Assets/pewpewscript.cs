using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pewpewscript : MonoBehaviour {

	public AudioClip pewpewSound;


	// Use this for initialization
	void Start () {
		//DontDestroyOnLoad(gameObject);

	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown (KeyCode.C)) {
			GetComponent<AudioSource> ().PlayOneShot (pewpewSound);

		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			GetComponent<AudioSource> ().PlayOneShot (pewpewSound);

		}


	}
}
