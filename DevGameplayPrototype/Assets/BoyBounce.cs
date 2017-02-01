using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoyBounce : MonoBehaviour {
	public Rigidbody2D rb;
	public SpriteRenderer sr;
	public int TimeLeft = 0;

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
		if (TimeLeft == 10) {
			rb.velocity = new Vector3 (rb.velocity.x, 100, 0);
			TimeLeft = 0;


		}

	}

	void OnCollisionEnter2D(Collision2D other) {
		if (Input.GetKey (KeyCode.Space)) {
			rb.velocity = new Vector3 (rb.velocity.x, 5, 0);
			TimeLeft++;
		} 
		else {
			rb.velocity = new Vector3 (rb.velocity.x, 50, 0);
			TimeLeft = 0;
		}
	}
}
