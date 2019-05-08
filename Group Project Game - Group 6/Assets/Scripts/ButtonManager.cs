using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {
	public void ReplayButton() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		Time.timeScale = 1;
	}
	public void NextLevel(string sceneName) {
		SceneManager.LoadScene(sceneName);
		Time.timeScale = 1;
	}
	public void MainMenuButton(string sceneName) {
		SceneManager.LoadScene(sceneName);
	}
	public void Quit() {
		Application.Quit();
	}
}
