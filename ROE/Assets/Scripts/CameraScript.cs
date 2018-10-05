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
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            //transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * Time.deltaTime * -rotationSpeed);
            //transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed);

            transform.RotateAround(player.transform.position, Vector3.up, Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed);
        }

        if (Input.GetAxis("Vertical") != 0)
        {
            transform.LookAt(player.transform);

            Vector3 zoomDir = transform.position - player.transform.position;
            //zoomDir.Normalize();

            transform.Translate(zoomDir * Input.GetAxis("Vertical") * Time.deltaTime * -zoomSpeed);
            //transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * Time.deltaTime * -rotationSpeed);
            //transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed);

            //transform.RotateAround(player.transform.position, Vector3.up, Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed);
        }

        //if (Input.GetKeyDown("left") || Input.GetKeyDown("right"))
        //{
        //    transform.Rotate(Vector3.right * Time.deltaTime);
        //}

    }
}
