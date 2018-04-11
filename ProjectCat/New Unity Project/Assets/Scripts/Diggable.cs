using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diggable : MonoBehaviour {

	public int hits;
	// Use this for initialization
	void Start () {
		hits = 1;
	}

	// Update is called once per frame
	void Update () {
		if (hits < 1) {
			Destroy (gameObject);
		}
	}

	public void dig(){
		hits--;
	}
}
