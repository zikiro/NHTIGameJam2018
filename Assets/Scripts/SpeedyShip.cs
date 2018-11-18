using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedyShip : MonoBehaviour {

    private GameObject cannonball;
    //ShipCannons
    private GameObject cannonFrontMiddle;
    private GameObject cannonFrontLeft;
    private GameObject cannonFrontRight;
    private GameObject cannonBackLeft;
    private GameObject cannonBackRight;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            Instantiate(cannonball);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {

        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {

        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {

        }
        if(Input.GetKeyDown(KeyCode.Space))
        {

        }
    }
}
