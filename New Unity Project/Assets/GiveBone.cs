using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveBone : StateMachineBehaviour {


	private void OnStateUpdate(){
		Destroy (GameObject.FindGameObjectWithTag ("goldBone"));
	}
}
