using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterNextLevel : MonoBehaviour {

	private PlayerController playerController;
	private int totalEnemies;
	private bool finished;
	public string nextScene;
	// Use this for initialization
	void Start () {
		playerController = GetComponent<PlayerController> ();
		totalEnemies = playerController.getTotalEnemies ();
		finished = false;
	}

	// Update is called once per frame
	void Update () {
		if (totalEnemies == playerController.getEnemiesKilled ()) {
			finished = true;
		}

		if (finished) {
			if ((Input.GetKeyUp(KeyCode.Return)) && (nextScene != null)) {
				SceneManager.LoadScene(nextScene);
			}
		}
	}
}
