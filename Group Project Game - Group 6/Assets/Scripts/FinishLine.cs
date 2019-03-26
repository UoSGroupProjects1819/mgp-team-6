using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class FinishLine : MonoBehaviour
{
	public SceneAsset nextScene;

	private void OnCollisionEnter2D(Collision2D collision) {
		SceneManager.LoadScene(nextScene.name);
	}
}
