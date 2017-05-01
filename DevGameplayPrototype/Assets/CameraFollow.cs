using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraFollow : MonoBehaviour {
	

	public Transform target;
	float counter = 10;
	float mag = 0.2f;
	public float moveSpeed = 5f;
	public bool DeadOrNah = false;



	// Update is called once per frame
	void Update () {
	//	float xPos = Random.Range(-mag, mag);
	//	float yPos = Random.Range(-mag, mag);

		/**if (DeadOrNah == true) {
			float xPos = Random.Range (-mag, mag);
			float yPos = Random.Range (-mag, mag);
		**/
		/**	if (counter > 0) {
				transform.position = new Vector3 (xPos, yPos, 0);
				counter -= Time.deltaTime;
	}**/

			if (counter <= 0) {
				SceneManager.LoadScene ("DeathScreen");
			}
	Vector2 targetPosition = Vector2.Lerp(transform.position, target.position, moveSpeed * Time.deltaTime);

		/**	if (Input.GetKey (KeyCode.Space)) {
				transform.position = new Vector3(xPos, yPos, 0);
				mag = mag + 0.1f;	
			}**/
		transform.position = new Vector3 (transform.position.x, targetPosition.y, transform.position.z);




		
	/**
		float oldY = transform.position.y;

		if (targetPosition.y < oldY && Mathf.Abs( target.position.y - transform.position.y) <= 20) {
			targetPosition.y = oldY;
		}
	**/					

	}
}

