using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShovelController : MonoBehaviour {

	private GameObject[] dc;
	private Vector3 playerPos;
	private float[] offset;
	private DiggableController currentScript;
	// Use this for initialization
	void Start () {
		dc = GameObject.FindGameObjectsWithTag ("Diggable");
		offset = new float[dc.Length];
	}
	
	// Update is called once per frame
	void Update () {
		dc = GameObject.FindGameObjectsWithTag ("Diggable");
		playerPos = GameObject.FindGameObjectWithTag ("Player").transform.position;
		if (Input.GetKeyUp (KeyCode.Q)) {
			for (int i = 0; i < dc.Length; i++) {
				offset [i] = Vector3.Distance(playerPos, dc [i].transform.position);
				if (offset [i] < 14.0f) {
					currentScript = dc [i].GetComponent<DiggableController> ();
					currentScript.dig ();
				}
			}
		}

	}


}
