using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	public int collectibles;
	public Text collectiblesText;
	public GameObject deathScreen;
	public int abilityMode;

	private void Update() {

		if (Input.GetKeyDown("1")) {
			abilityMode = 0;
			print("Move");
		} else if (Input.GetKeyDown("2")) {
			abilityMode = 1;
			print("Scale");
		}
	}

	public void GameOver() {
		deathScreen.SetActive(true);
	}


}
