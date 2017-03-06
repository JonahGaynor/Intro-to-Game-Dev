using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DeathBarScript : MonoBehaviour {

	public Transform trans;

	public Transform target2;


	// Use this for initialization
	void Start () {
		trans = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		trans.position = new Vector3 (trans.position.x, trans.position.y + 0.25f, 0);

		if (trans.position.y > target2.position.y) {
			SceneManager.LoadScene ("DeathScreen");
		}
	}

}
