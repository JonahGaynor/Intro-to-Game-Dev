using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoyBounce : MonoBehaviour {
	public Rigidbody2D rb;
	public SpriteRenderer sr;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		sr = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			rb.velocity = new Vector3 (-8, rb.velocity.y, 0);
			sr.flipX = true;

		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			rb.velocity = new Vector3 (8, rb.velocity.y, 0);
			sr.flipX = false;
		}

	}

	void OnTriggerEnter2D(Collider2D other) {
		if (Input.GetKey (KeyCode.Space)) {
			rb.velocity = new Vector3 (rb.velocity.x, 5, 0);
		} 
		else {
			rb.velocity = new Vector3 (rb.velocity.x, 10, 0);
		}
	}
}
