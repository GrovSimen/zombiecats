using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollider : MonoBehaviour {

	private PlayerResources playerResources;
	private bool pickedUp;
	private ObjectResources objectResources;
	// Use this for initialization
	void Start ()
	{
		pickedUp = false;
		playerResources = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerResources> ();
		objectResources = GetComponent<ObjectResources> ();

	}

	// Update is called once per frame
	void Update ()
	{
		if (pickedUp) {
			playerResources.giveResource (objectResources.getResource());
			Destroy (gameObject);
		}
	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "Player") {
			pickedUp = true;
		} 
	}
}
