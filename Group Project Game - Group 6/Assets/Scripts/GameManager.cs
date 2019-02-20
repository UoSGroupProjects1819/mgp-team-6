using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	public int mana = 500;
	public Text manaText;
	public GameObject deathScreen;
	public int abilityMode;

	void Start() {
		manaText.text = mana.ToString();
	}

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
