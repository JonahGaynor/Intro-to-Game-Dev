using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DeathBarScript : MonoBehaviour {

	public Transform trans;
	public AudioClip sunSound;
	public Transform target2;
	public bool DeadOrNah = false;

	bool ifPlaying = false;


	// Use this for initialization
	void Start () {
		trans = GetComponent<Transform> ();

	}
	
	// Update is called once per frame
	void Update () {
		trans.position = new Vector3 (trans.position.x, trans.position.y + 0.25f, 0);

		if (trans.position.y+5 > target2.position.y) {
			DeadOrNah = true;
		//	SceneManager.LoadScene ("DeathScreen");
		}

		if (trans.position.y > target2.position.y - 20 && ifPlaying == false) {
			GetComponent<AudioSource>().PlayOneShot(sunSound);
			ifPlaying = true;
		}

		if (trans.position.y <= target2.position.y - 20) {
			ifPlaying = false;
		}
	}

}
