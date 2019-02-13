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
		gameManager.mana += 500;
		gameManager.manaText.text = gameManager.mana.ToString();
		Destroy(gameObject);
	}
}
