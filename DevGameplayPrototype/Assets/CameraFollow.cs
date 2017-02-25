using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Transform target;

	public float moveSpeed = 5f;

	// Update is called once per frame
	void Update () {
		Vector2 targetPosition = Vector2.Lerp(transform.position, target.position, moveSpeed * Time.deltaTime);

		float oldY = transform.position.y;

		if (targetPosition.y < oldY && Mathf.Abs( target.position.y - transform.position.y) <= 20) {
			targetPosition.y = oldY;
		}
			
			
		transform.position = new Vector3 (transform.position.x, targetPosition.y, transform.position.z);

	}
}
