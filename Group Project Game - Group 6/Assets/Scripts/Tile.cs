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
			StartCoroutine(MoveTile());
		}
	}

	IEnumerator MoveTile() {
		//Wait for the player to release mouse
		yield return new WaitUntil(() => Input.GetMouseButtonUp(0));

		//Get where mouse is
		Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

		//Figure out what direction from the block it is
		Vector2 heading = mousePos - (Vector2)transform.position;
		Vector2 direction = heading / heading.magnitude;
		direction = new Vector2(Mathf.Round(direction.x), Mathf.Round(direction.y));

		//If diagonal, just choose one of the 2 directions randomly
		if (direction.x != 0 && direction.y != 0) {
			if (Random.Range(0, 1) == 0) {
				direction = new Vector2(0, direction.y);
			} else {
				direction = new Vector2(direction.x, 0);
			}
		}

		//Subtract mana
		gameManager.mana -= 100;
		gameManager.manaText.text = gameManager.mana.ToString();

		//Move in that direction
		target = (Vector2)transform.position + direction;
		moved = true;

		yield return new WaitForSeconds(5);

		//Move back
		moved = false;
		target = (Vector2)transform.position - direction;
	}

	private void Update() {
		transform.position = Vector3.MoveTowards(transform.position, target, 5 * Time.deltaTime);
	}
}
