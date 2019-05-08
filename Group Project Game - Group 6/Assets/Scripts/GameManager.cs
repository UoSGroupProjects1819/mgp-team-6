using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	public int collectibles;
	public Text collectiblesText;
	public GameObject deathScreen;
	public GameObject winScreen;
	public int abilityMode;

	private void Update() {

		if (Input.GetKeyDown("1")) {
			abilityMode = 0;
		} 
	}

	public void GameOver() {
		deathScreen.SetActive(true);
	}

	public void Win() {
		winScreen.SetActive(true);
	}


}
