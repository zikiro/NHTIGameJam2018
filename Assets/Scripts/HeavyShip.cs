using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyShip : MonoBehaviour {

    public GameObject cannonball;
    public GameObject miniCannonball;
    //ShipCannons
    public GameObject cannonFrontMiddle;
    public GameObject cannonFrontLeft;
    public GameObject cannonFrontRight;
    public GameObject cannonBackLeft;
    public GameObject cannonBackRight;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Instantiate(cannonball, new Vector3(cannonFrontLeft.transform.position.x, cannonFrontLeft.transform.position.y, cannonFrontLeft.transform.position.z), cannonFrontLeft.transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {

            Instantiate(cannonball, new Vector3(cannonFrontRight.transform.position.x, cannonFrontRight.transform.position.y, cannonFrontRight.transform.position.z), cannonFrontRight.transform.rotation);

        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {

            Instantiate(cannonball, new Vector3(cannonBackLeft.transform.position.x, cannonBackLeft.transform.position.y, cannonBackLeft.transform.position.z), cannonBackLeft.transform.rotation);

        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {

            Instantiate(cannonball, new Vector3(cannonBackRight.transform.position.x, cannonBackRight.transform.position.y, cannonBackRight.transform.position.z), cannonBackRight.transform.rotation);

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {

            Instantiate(miniCannonball, new Vector3(cannonFrontMiddle.transform.position.x, cannonFrontMiddle.transform.position.y, cannonFrontMiddle.transform.position.z), cannonFrontMiddle.transform.rotation);

        }
    }
}
