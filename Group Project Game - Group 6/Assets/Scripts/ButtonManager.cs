using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class ButtonManager : MonoBehaviour {
	public void ReplayButton() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		Time.timeScale = 1;
	}
	public void NextLevel(SceneAsset nextScene) {
		SceneManager.LoadScene(nextScene.name);
		Time.timeScale = 1;
	}
	public void MainMenuButton(SceneAsset nextScene) {
		SceneManager.LoadScene(nextScene.name);
	}
	public void Quit() {
		Application.Quit();
	}
}
