using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManagerScript : MonoBehaviour {

	public AudioClip musicPlay;
	public static bool haveLoadedAudioManager = false;

	// Use this for initialization
	void Start () {

		SceneManager.sceneLoaded += OnSceneLoaded;

		if (haveLoadedAudioManager) {
			Destroy (gameObject);
		}
		else {
			DontDestroyOnLoad(gameObject);

				haveLoadedAudioManager = true;
		}

		}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnSceneLoaded (Scene scene, LoadSceneMode mode) {
		if (scene.name == "DeathScreen") {
			GetComponent<AudioSource> ().Stop ();
		}
		if (scene.name == "HomeScreen") {
			GetComponent<AudioSource> ().Stop ();
			GetComponent<AudioSource> ().PlayOneShot (musicPlay);
		}
	}
}
