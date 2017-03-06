using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoyBounce : MonoBehaviour {
	public Rigidbody2D rb;
	public SpriteRenderer sr;
	public int TimeLeft = 0;
	public int yVelocity = 50;
	public int velCharge = 0;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		sr = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			rb.velocity = new Vector3 (-15, rb.velocity.y, 0);
			sr.flipX = true;

		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			rb.velocity = new Vector3 (15, rb.velocity.y, 0);
			sr.flipX = false;
		}
		if (Input.GetKeyUp (KeyCode.Space) && rb.velocity.y == 0) {
			rb.velocity = new Vector3 (rb.velocity.x, yVelocity + velCharge, 0);
			velCharge = 0;
			TimeLeft = 0;
		}
		if (TimeLeft == 50) {
			TimeLeft = 0;
			SceneManager.LoadScene ("DeathScreen");
		}

		Vector3 pos = transform.position;

		SpriteRenderer sprtrnd = GameObject.Find ("Background1").GetComponent<SpriteRenderer> ();

		float HalfScreenSize = sprtrnd.bounds.extents.x;

		pos.x = Mathf.Repeat (pos.x + HalfScreenSize, HalfScreenSize * 2) - HalfScreenSize;

		transform.position = pos;

		if (Input.GetKey (KeyCode.Space)) {
			TimeLeft++;
		}



	//	if (transform.position.y < MainCamera.position.x - 50) {
	//		SceneManager.LoadScene ("DeathScreen");
	//	}

	}

	void OnCollisionEnter2D(Collision2D other) {
		if (Input.GetKey (KeyCode.Space)) {
			rb.velocity = new Vector3 (rb.velocity.x, 0, 0);
			TimeLeft++; 
			if (other.gameObject.name == "ChargePlatform") {
				velCharge=50;
			} 
		}
		if (other.gameObject.name == "DisappearPlatform") {
			rb.velocity = new Vector3 (rb.velocity.x, rb.velocity.y, 0);
		}
		else {
			rb.velocity = new Vector3 (rb.velocity.x, yVelocity + velCharge, 0);
			TimeLeft = 0;
			velCharge = 0;
		}
			
	}

	
}
