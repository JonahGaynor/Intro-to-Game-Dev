using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {

	public AudioClip selectSound;
	int delayVariable = 0;
	float counter = 100;
	float mag = 10f;
	bool creditPress = false;
	AudioSource pewpewSound;



	// Use this for initialization
	void Start () {
		pewpewSound = GetComponent<AudioSource> ();
		pewpewSound.gameObject.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {

		float xPos = Random.Range (-mag, mag);
		float yPos = Random.Range (-mag, mag);

		if (counter > 0) {
			transform.position = new Vector3 (xPos, yPos, 0);

			counter -= Time.deltaTime;
		}

		if (Input.GetKeyUp (KeyCode.Space)) {
			while (delayVariable < 100) {
				delayVariable++;
			}
			if (delayVariable == 100) {
				delayVariable = 0;
			}
			pewpewSound.PlayOneShot (selectSound);
			SceneManager.LoadScene ("Level1");
			pewpewSound.gameObject.SetActive (false);


		}

		

		if (Input.GetKeyUp (KeyCode.I)) {
			while (delayVariable < 100) {
				delayVariable++;
			}
			if (delayVariable == 100) {
				pewpewSound.PlayOneShot (selectSound);
				SceneManager.LoadScene ("InstructionsScreen");
				pewpewSound.gameObject.SetActive (false);

				//GetComponent<AudioSource> ().PlayOneShot (selectSound);
				delayVariable = 0;
			}
		}


		if (Input.GetKeyUp (KeyCode.C)) {
			creditPress = true;
			//while (creditPress == true) {
			//	delayVariable++;
			//}
			//if (delayVariable == 10) {
				pewpewSound.PlayOneShot (selectSound);
				SceneManager.LoadScene ("Credits");
				pewpewSound.gameObject.SetActive (false);

			//	delayVariable = 0;
			//}
		}
	}
}
