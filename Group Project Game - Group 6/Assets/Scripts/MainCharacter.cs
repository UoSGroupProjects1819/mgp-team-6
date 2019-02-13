using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacter : MonoBehaviour {

	public float speed = 1;
	private Vector3 direction = new Vector3(1,0,0);

	private void FixedUpdate() {
		transform.position = Vector2.MoveTowards(transform.position, transform.position + direction, speed * Time.fixedDeltaTime);
	}

	private void OnCollisionEnter2D(Collision2D collision) {
		if (transform.InverseTransformPoint(collision.transform.position).y > 0) {
			direction *= -1;
		}

	}

}

