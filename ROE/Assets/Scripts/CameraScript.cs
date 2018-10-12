using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public float rotationSpeed;
    public float zoomSpeed;
    public GameObject player;

    // Use this for initialization
    void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        // Set to view point
        //transform.LookAt(new Vector3(0.0f, 1.0f, 0.0f));
    }
	
	// Update is called once per frame
	void Update ()
    {
        //if (Input.GetAxis("Horizontal") != 0)
        //{
        //    transform.RotateAround(player.transform.position, Vector3.up, Input.GetAxis("Horizontal") * Time.deltaTime * -rotationSpeed);
        //}

        //if (Input.GetAxis("Vertical") != 0)
        //{
        //    transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * Time.deltaTime * zoomSpeed);
        //}

        if (Input.GetButton("RotLeft"))
        {
            transform.RotateAround(player.transform.position, Vector3.up, Time.deltaTime * rotationSpeed);
        }

        if (Input.GetButton("RotRight"))
        {
            transform.RotateAround(player.transform.position, Vector3.up, Time.deltaTime * -rotationSpeed);
        }

        if (Input.GetAxis("ZoomIn") != -1.0f)
        {
            transform.Translate(Vector3.forward * (Input.GetAxis("ZoomIn") + 1.0f) * 0.5f * Time.deltaTime * zoomSpeed);
            Debug.Log("R2 value " + Input.GetAxis("ZoomIn"));
        }

        if (Input.GetAxis("ZoomOut") != -1.0f)
        {
            transform.Translate(Vector3.forward * (Input.GetAxis("ZoomOut") + 1.0f) * 0.5f * Time.deltaTime * -zoomSpeed);
            Debug.Log("L2 value " + Input.GetAxis("ZoomOut"));
        }

    }
}
