using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour {

    private int damageToGive;

	void Start(){
		damageToGive = 1;
	}

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerHealthManager>().HurtPlayer(damageToGive);
        }
    }
}
