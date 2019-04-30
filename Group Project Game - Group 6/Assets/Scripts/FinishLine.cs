using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class FinishLine : MonoBehaviour
{
	public SceneAsset nextScene;
	public GameManager gameManager;

	private void OnCollisionEnter2D(Collision2D collision) {
		gameManager.Win();
		Time.timeScale = 0;
		collision.gameObject.GetComponent<SpriteRenderer>().enabled = false;
	}
}
