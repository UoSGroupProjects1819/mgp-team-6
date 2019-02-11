using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour{

	private GameManager gameManager;
	private Vector3 target;
	private bool moved;
	public bool movable = true;

	private void Start() {
		gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
		target = transform.position;
	}

	void OnMouseOver() {
		if (Input.GetMouseButtonDown(0) && !moved && gameManager.mana >= 100 && movable) {
			gameManager.mana -= 100;
			gameManager.manaText.text = gameManager.mana.ToString();
			StartCoroutine(MoveTile());
		}
	}

	IEnumerator MoveTile() {
		target = transform.position + new Vector3(0, 1, 0);
		moved = true;
		yield return new WaitForSeconds(5);
		moved = false;
		target = transform.position - new Vector3(0, 1, 0);
	}

	private void Update() {
		transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime);
	}
}
