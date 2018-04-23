using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatorController : MonoBehaviour {

	private Vector3 pos1;
	private Vector3 pos2;
	private Animator anim;
	private float time;
	// Use this for initialization
	void Start () {
		pos1 = transform.position;
		anim = gameObject.GetComponent<Animator> ();
		time = 0;
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		if (time > 0.02) {
			pos2 = transform.position;
			if (pos1 != pos2) {
				time = 0;
				pos1 = pos2;
				anim.ResetTrigger ("move");
				anim.SetTrigger ("move");
			} else {
				anim.ResetTrigger ("move");
				anim.SetTrigger ("idle");
			}
		} 
	}

	private bool ifMovement(){
		
		if (time > 0.2) {
			pos2 = transform.position;

			pos1 = pos2;
		}
		return false;
	}

	public void throwBalloon(){
		anim.ResetTrigger ("throw");
		anim.SetTrigger ("throw");
	}
				
}
