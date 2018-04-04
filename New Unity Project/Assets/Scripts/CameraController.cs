using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;

    public bool zoomEnabled;

    private Vector3 offset;
    private Vector3 temp;

    private float zoomInput;
    private float oldZoomInput;
    private int zoom;
    private int yMinCap = 30;
    private int yMaxCap = 83;


	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position;
        oldZoomInput = zoomInput;
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = player.transform.position + offset;
        zoomInput = Input.GetAxisRaw("Mouse ScrollWheel");

        if(zoomInput != oldZoomInput)
        {
            if((zoomInput > oldZoomInput) && (yMinCap < gameObject.transform.position.y) && (zoomEnabled))
            {
                temp = new Vector3(0, 2, -1);
                transform.position -= temp;
                offset = transform.position - player.transform.position;
            } else if ((zoomInput < oldZoomInput) && (yMaxCap > gameObject.transform.position.y) && (zoomEnabled))
            {
                temp = new Vector3(0, -2, 1);
                transform.position -= temp;
                offset = transform.position - player.transform.position;
            }
        }

        
	}
}
