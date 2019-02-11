using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacter : MonoBehaviour {

	public float speed = 1;

    void Update() {
        GetComponent<Rigidbody>().MovePosition(transform.position + transform.forward * speed * Time.deltaTime);
	}
}
