using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoyBounce : MonoBehaviour {
	public Rigidbody2D rb;
	public SpriteRenderer sr;
	public int TimeLeft = 0;
	public int yVelocity = 150;

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
		if (Input.GetKeyUp (KeyCode.Space) && rb.velocity.y==0) {
			rb.velocity = new Vector3 (rb.velocity.x, yVelocity, 0);
		}
		if (TimeLeft == 10) {
			TimeLeft = 0;
			Application.LoadLevel ("DeathScreen");
		}

		Vector3 pos = transform.position;

		float HalfScreenSize = 39.0f;

		pos.x = Mathf.Repeat(pos.x+HalfScreenSize,HalfScreenSize*2)-HalfScreenSize;

		transform.position = pos;


	}

	void OnCollisionEnter2D(Collision2D other) {
		if (Input.GetKey (KeyCode.Space)) {
			rb.velocity = new Vector3 (rb.velocity.x, 0, 0);
			TimeLeft++;
		} 
		else {
			rb.velocity = new Vector3 (rb.velocity.x, yVelocity, 0);
			TimeLeft = 0;
		}
	}
}
