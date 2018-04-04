using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour {

	private TextMesh textObject;
	private PlayerController pc;

	void Start () {
		textObject = GameObject.Find ("enemyUI").GetComponent<TextMesh> ();
		pc = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerController>();
	}

	// Update is called once per frame
	void Update () {
		textObject.text = "Fiender: " + pc.getEnemiesKilled () + "/" + pc.getTotalEnemies();
	}
}
