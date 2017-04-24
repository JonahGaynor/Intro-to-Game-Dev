using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {

	public AudioClip selectSound;
	int delayVariable = 0;
	float counter = 100;
	float mag = 10f;

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {

			float xPos = Random.Range(-mag, mag);
			float yPos = Random.Range(-mag, mag);

			if (counter > 0) {
				transform.position = new Vector3(xPos, yPos, 0);

				counter -= Time.deltaTime;
			}

		if (Input.GetKeyUp (KeyCode.Space)) {
			while (delayVariable < 100) {
				delayVariable++;
			}
			if (delayVariable == 100) {
				SceneManager.LoadScene ("Level1");
				GetComponent<AudioSource> ().PlayOneShot (selectSound);
				delayVariable = 0;
			}
		}

		if (Input.GetKeyUp (KeyCode.I)) {
			while (delayVariable < 1000) {
				delayVariable++;
			}
			if (delayVariable == 1000) {
				SceneManager.LoadScene ("InstructionsScreen");
				GetComponent<AudioSource> ().PlayOneShot (selectSound);
				delayVariable = 0;
			}
		}
		if (Input.GetKeyUp (KeyCode.C)) {
			while (delayVariable < 1000) {
				delayVariable++;
			}
			if (delayVariable == 1000) {
				SceneManager.LoadScene ("Credits");
				GetComponent<AudioSource> ().PlayOneShot (selectSound);
				delayVariable = 0;
			}
		}
	}
}
