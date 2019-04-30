using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
	private GameManager gameManager;
	private void Start() {
		gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
	}
	private void OnTriggerEnter2D(Collider2D collision) {
		gameManager.collectibles += 1;
		gameManager.collectiblesText.text = gameManager.collectibles.ToString();
		Destroy(gameObject);
	}
}
