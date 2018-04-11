using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    private Rigidbody myRB;
    public float moveSpeed;
	private float dist;
    public PlayerController thePlayer;
	private GameObject player;
	public float scopeRadius;
	public float timeA;
	// Use this for initialization
	void Start ()
    {	
		player = GameObject.FindGameObjectWithTag ("Player");
        myRB = GetComponent<Rigidbody>();
        thePlayer = FindObjectOfType<PlayerController>();
		timeA = 5.0f;

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
			// if pos == pos transform left?
			if (timeA + 5.0f < Time.realtimeSinceStartup) {
				myRB.velocity = (transform.forward * moveSpeed);
			}
		}
    }

	void OnCollisionEnter(Collision collision){
		print ("collided");
		timeA = Time.realtimeSinceStartup;
		myRB.velocity = Vector3.Scale( Vector3.left , (transform.forward * moveSpeed));
	}

}
