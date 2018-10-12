using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnMinion : MonoBehaviour {


    public int health = 100;
    public float minionSpawnTime = 5.0f;

    float currSpawnTime;
    float tempTime = 0.0f;



    public GameObject workerMinion;
    private GameObject currObject;
    public Camera mainCam;
    public Slider buildTimeBar;

    public Canvas buildingPanel;
    private Canvas tempBuildingCanvas;

    private bool startTimer;
    private bool showAttributes;
    private bool selected;
    private int count = 0;
	// Use this for initialization
	void Start ()
    {

	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { // if left button pressed...
            Ray ray = mainCam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // the object identified by hit.transform was clicked
                // do whatever you want
                currObject = hit.transform.gameObject;

            }
        }


        SpawnMinions();

        Timer();

        ShowBuildingAttributes(currSpawnTime);

    }

    public void SpawnMinions()
    {

        BuildingSelected();

        //if q has been pressed instansiate a minion 
        if (Input.GetKeyDown(KeyCode.Q) && selected)
        {
            startTimer = true;   

            if (tempTime >= minionSpawnTime)
            {
                Instantiate(workerMinion, new Vector3(1.0f, 1.0f, 5.0f), Quaternion.identity);

                startTimer = false;
                tempTime = 0.0f;
            }
        }

     
    }

    void BuildingSelected()
    {
        //if the current object selected is this object
        if (currObject == this.gameObject)
        {
            //the building has been selected
            selected = true;


            //if there is not a canvas already in the scene
            if (count != 1)
            {
          

                //instansiate a canvas
                tempBuildingCanvas = Instantiate(buildingPanel, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);

                //turn it on in the scene
                tempBuildingCanvas.gameObject.SetActive(true);
                showAttributes = true;

                //canvas count 
                count++;
            }

            //set this object to red if it is selected to show it has been selected
            this.GetComponent<Renderer>().material.color = Color.red;
        }

        else if (currObject != this.gameObject)
        {
            //if another object has been selected change the colour of the object back to white and destroy its canvas
            selected = false;
            this.GetComponent<Renderer>().material.color = Color.white;
            Destroy(tempBuildingCanvas.gameObject);
            count = 0;
        }
    }

    void ShowBuildingAttributes(float spawnTime)
    {
        if (showAttributes)
        {
            Slider healthBar;
         

            //Show health bar
            healthBar = tempBuildingCanvas.GetComponentInChildren<Slider>();
            healthBar.gameObject.SetActive(true);
            healthBar.maxValue = health;
            healthBar.value = health;
            healthBar.transform.position = mainCam.WorldToScreenPoint(this.transform.position);
            healthBar.transform.position -= new Vector3(0.0f, 50.0f, 0.0f);


            buildTimeBar.gameObject.SetActive(true);
            buildTimeBar.maxValue = minionSpawnTime;
            buildTimeBar.value = tempTime;


        }

        
    }

    float Timer()
    {
        if (startTimer)
        {
          tempTime += Time.deltaTime;
        }
        return tempTime;
    }

    
}
