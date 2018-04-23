using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    private Rigidbody myRB;
    private float moveSpeed;
	private float dist;
    private PlayerController thePlayer;
	private GameObject player;
	private float scopeRadius;
	// Use this for initialization
	void Start ()
    {	
		player = GameObject.FindGameObjectWithTag ("Player");
        myRB = GetComponent<Rigidbody>();
        thePlayer = FindObjectOfType<PlayerController>();
		scopeRadius = 50.0f;
		moveSpeed = 15;

	}
	
	// Update is called once per frame
	void Update ()
    {
		dist = Vector3.Distance (player.transform.position, gameObject.transform.position);
        transform.LookAt(thePlayer.transform.position);

	}

    private void FixedUpdate()
    {
		if (dist < scopeRadius) {
				myRB.velocity = (transform.forward * moveSpeed);
			print (dist);
		}
    }
		

}
