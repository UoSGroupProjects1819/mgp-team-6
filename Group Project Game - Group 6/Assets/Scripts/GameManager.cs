using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	public int mana = 500;
	public Text manaText;
	public GameObject deathScreen;

	void Start() {
		manaText.text = mana.ToString();
	}

	public void GameOver() {
		deathScreen.SetActive(true);
	}
}
