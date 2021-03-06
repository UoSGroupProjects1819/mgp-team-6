﻿using System.Collections;
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



	private void OnCollisionStay2D(Collision2D collision) {
		if (collision.collider.bounds.Contains(transform.GetComponent<Renderer>().bounds.center)) {
			Die();
		}
        if (transform.InverseTransformPoint(collision.transform.position).y > 0) {
            direction *= -1;
			GetComponent<Animator>().Play("FlipAnimation");
			SpriteRenderer spriteR = GetComponent<SpriteRenderer>();
			if (spriteR.flipX) {
				spriteR.flipX = false;
			} else {
				spriteR.flipX = true;
			}
		}
    }

	public void Die() {
		gameManager.GameOver();
		Time.timeScale = 0;
		GetComponent<SpriteRenderer>().enabled = false;
	}
}

