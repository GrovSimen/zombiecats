using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectResources : MonoBehaviour {

	private int amountOfDiggablesLeft;
	private string resource;
	private bool gotKey;
	private PlayerResources playerResources;
	// Use this for initialization
	void Start () {
		gotKey = false;
		resource = "";
		playerResources = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerResources> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(gameObject.CompareTag("Chest")){
			resource = "golden bone";
		} else {
			amountOfDiggablesLeft = GameObject.FindGameObjectsWithTag ("Diggable").Length;
			if (playerResources.getKeys () > 0 && gotKey == false) {
				gotKey = true;
			}
			decideResource ();
		}
	}

	public string getResource(){
		return resource;
	}

	private void decideResource(){
		if ((amountOfDiggablesLeft <= 1) && (gotKey == false)) {
			resource = "key";

		} else {
			float rand = Random.value;

			if (rand < 0.05f && gotKey == false) {
				resource = "key";
			} else if (rand < 0.3f) {
				resource = "coin";
			} else if (rand >= 0.3f) {
				resource = "bone";
			}
		}
	}
}
