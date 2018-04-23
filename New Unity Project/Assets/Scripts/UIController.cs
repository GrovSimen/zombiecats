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

		if (0 == pc.getEnemiesLeft()) {
			textObject.text = "Trykk enter \n for å begynde neste nivå" ;
		} else {
			textObject.text = "Fiender: " + pc.getEnemiesLeft () + "/" + pc.getTotalEnemies();
		}

	}
}
