using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    public float moveSpeed;
    private Rigidbody myRigidbody;

    private Vector3 moveInput;
    private Vector3 moveVelocity;

    private Camera mainCamera;

    public GunController theGun;

	private float distanceChest;

	private GameObject chest;

	private ChestController chestController;

	private int enemiesTotal;

	private int enemiesKilled;

	private Terrain t;
    // Use this for initialization
    void Start()
    {	
        myRigidbody = GetComponent<Rigidbody>();
        mainCamera = FindObjectOfType<Camera>();
		enemiesKilled = 0;
		enemiesTotal = GameObject.FindGameObjectsWithTag ("Enemy").Length;
		chest = GameObject.FindGameObjectWithTag ("Chest");
		chestController = chest.GetComponent<ChestController> ();
		t = FindObjectOfType<Terrain> ();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput * moveSpeed;

        Ray cameraRay = mainCamera.ScreenPointToRay(Input.mousePosition);
        Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
        float rayLength;


        if (groundPlane.Raycast(cameraRay, out rayLength))
        {
                Vector3 pointToLook = cameraRay.GetPoint(rayLength);
                Debug.DrawLine(cameraRay.origin, pointToLook, Color.blue);

                transform.LookAt(new Vector3(pointToLook.x, transform.position.y, pointToLook.z));
				updateScore ();
        }

        if(Input.GetMouseButtonDown(0))
        {
            theGun.isFiring = true;
        }
        if(Input.GetMouseButtonUp(0))
        {
            theGun.isFiring = false;
        }
		chestChecker ();
    }

    private void FixedUpdate()
    {
        myRigidbody.velocity = moveVelocity;
    }

	private void updateScore(){
		enemiesKilled = enemiesTotal - (enemiesTotal - GameObject.FindGameObjectsWithTag ("Enemy").Length);
	}

	public int getEnemiesKilled(){
		return enemiesKilled;
	}

	public int getTotalEnemies(){
		return enemiesTotal;
	}

	private void chestChecker(){
		distanceChest = Vector3.Distance (gameObject.transform.position, chest.transform.position);
		if(Input.GetKeyUp (KeyCode.E)) {
				if(distanceChest < 14.0f){
					chestController.setOpen();
				}
		}
	}

	private void posChecker(){
		if (gameObject.transform.position.x < 0 || gameObject.transform.position.z < 0 || gameObject.transform.position.x > t.terrainData.size.x || gameObject.transform.position.z > t.terrainData.size.z) {
			print ("Out of bounds");
		}
	}
}
