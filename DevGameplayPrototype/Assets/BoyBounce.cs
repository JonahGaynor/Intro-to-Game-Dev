using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoyBounce : MonoBehaviour {
	public Rigidbody2D rb;
	public SpriteRenderer sr;
	public TrailRenderer tr;
	public int TimeLeft = 0;
	public int yVelocity = 50;
	public int velCharge = 0;
	public AudioClip jumpSound;
	public Sprite SteveAudienceLeftJump;
	public Sprite SteveAudienceRightJump;
	public Sprite SteveCharge;
	public Sprite SteveJump;
	public GameObject chargeParticle;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		sr = GetComponent<SpriteRenderer> ();
		tr = GetComponent<TrailRenderer> ();
		tr.sortingOrder = 49;

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.LeftArrow)) {
			rb.velocity = new Vector3 (-15, rb.velocity.y, 0);
			sr.sprite = SteveAudienceLeftJump;
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			rb.velocity = new Vector3 (15, rb.velocity.y, 0);
			sr.sprite = SteveAudienceRightJump;
		}
		if (Input.GetKeyUp (KeyCode.Space) && rb.velocity.y == 0) {
			rb.velocity = new Vector3 (rb.velocity.x, yVelocity + velCharge, 0);
			sr.sprite = SteveJump;
			velCharge = 0;
			TimeLeft = 0;
			GetComponent<AudioSource>().PlayOneShot(jumpSound);
			Instantiate (chargeParticle, transform.position, transform.rotation);
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
			sr.sprite = SteveCharge;
			TimeLeft++;
		}


	}

	void OnCollisionEnter2D(Collision2D other) {
		if (Input.GetKey (KeyCode.Space)) {
			rb.velocity = new Vector3 (rb.velocity.x, 0, 0);
			TimeLeft++; 
			if (other.gameObject.name == "ChargePlatform") {
				velCharge = 50;
			} 
		} else if (other.gameObject.name == "DisappearPlatform") {
			rb.velocity = new Vector3 (rb.velocity.x, rb.velocity.y, 0);
			if (other.gameObject.transform.position.y < gameObject.transform.position.y) {
				GetComponent<AudioSource> ().PlayOneShot (jumpSound);
			}
		} else if (other.gameObject.name == "EndPlatform") {
			yVelocity = yVelocity + 50;
			rb.gravityScale = rb.gravityScale + 10;
		}

		else {
			rb.velocity = new Vector3 (rb.velocity.x, yVelocity + velCharge, 0);
			if (other.gameObject.transform.position.y < gameObject.transform.position.y) {
				GetComponent<AudioSource> ().PlayOneShot (jumpSound);
			}
			TimeLeft = 0;
			velCharge = 0;
		}
			
	}

	
}
