using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacter : MonoBehaviour {

	public float speed = 1;

	private void FixedUpdate() {
		transform.position = Vector2.MoveTowards(transform.position, transform.position + transform.right, speed * Time.fixedDeltaTime);
	}
}

