using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour {

	// Use this for initialization
	Animator anim;
	private bool open;
	void Start () {
		open = false;
		anim = gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (open) {
			anim.SetTrigger ("Active");
		}
	}

	public void setOpen(){
		open = true;
	}
}
