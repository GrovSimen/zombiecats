using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiggableController : MonoBehaviour {
				
	private int health;
	private ObjectResources objectResources;
	private PlayerResources playerResources;
	// Use this for initialization
	void Start () {
		health = 1;
		objectResources = GetComponent<ObjectResources> ();
		playerResources = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerResources> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (health <= 0) {
			playerResources.giveResource (objectResources.getResource());
			Destroy (this.gameObject);
		}
	}

	public void dig(){	
		health--;
	}

	public Vector3 getPos(){
		return gameObject.transform.position;
	}
}
