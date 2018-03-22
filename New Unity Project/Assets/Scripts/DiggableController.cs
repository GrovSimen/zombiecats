using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiggableController : MonoBehaviour {

	private int health;
	// Use this for initialization
	void Start () {
		health = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (health <= 0) {
			Destroy (this.gameObject);
		}
	}

	public void dig(){
		print ("dig");
		health--;
	}

	public Vector3 getPos(){
		return gameObject.transform.position;
	}
}
