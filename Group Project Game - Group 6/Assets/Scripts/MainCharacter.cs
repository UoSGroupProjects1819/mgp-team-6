using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacter : MonoBehaviour {

	private GameManager gameManager;
	public float speed = 1;
	private Vector3 direction = new Vector3(1,0,0);

	private void Start() {
		gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
	}

	private void FixedUpdate() {
		transform.position = Vector2.MoveTowards(transform.position, transform.position + direction, speed * Time.fixedDeltaTime);
	}

	private void OnCollisionEnter2D(Collision2D collision) {
		if (transform.InverseTransformPoint(collision.transform.position).y > 0) {
			direction *= -1;
		}
	}

	private void OnCollisionStay2D(Collision2D collision) {
		if (collision.collider.bounds.Contains(transform.position)) {
			gameManager.GameOver();
			Time.timeScale = 0;
			GetComponent<SpriteRenderer>().enabled = false;

		}
	}
}

