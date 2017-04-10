using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerScript : MonoBehaviour {


	public static bool haveLoadedAudioManager = false;

	// Use this for initialization
	void Start () {
		if (haveLoadedAudioManager) {
			Destroy (gameObject);;
		}
		else {
			DontDestroyOnLoad(gameObject);

				haveLoadedAudioManager = true;
		}

		}
	
	// Update is called once per frame
	void Update () {
		
	}
}
