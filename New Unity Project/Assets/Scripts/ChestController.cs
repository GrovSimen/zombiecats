using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour {

	// Use this for initialization
	private PlayerResources playerResources;
	Animator anim;
	private bool open;
	void Start () {
		open = false;
		anim = gameObject.GetComponent<Animator> ();
		playerResources = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerResources> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (open) {
			anim.SetTrigger ("Active");
		}
	}

	public void setOpen(){
		if (playerResources.getKeys () > 0) {
			open = true;
		}
	}
}
