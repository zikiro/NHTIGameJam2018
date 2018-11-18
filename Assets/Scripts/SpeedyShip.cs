using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedyShip : MonoBehaviour {

    public GameObject cannonball;
    public GameObject miniCannonball;
    //ShipCannons
    public GameObject cannonFront;
    public GameObject cannonLeft;
    public GameObject cannonRight;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            GameObject clone;
            clone = Instantiate(cannonball, new Vector3(cannonLeft.transform.position.x, cannonLeft.transform.position.y, cannonLeft.transform.position.z), transform.rotation);
            clone.GetComponent<Rigidbody>().velocity = transform.TransformDirection(Vector3.forward * 10);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            GameObject clone;
            clone = Instantiate(cannonball, new Vector3(cannonRight.transform.position.x, cannonRight.transform.position.y, cannonRight.transform.position.z), transform.rotation);
            clone.GetComponent<Rigidbody>().velocity = transform.TransformDirection(Vector3.forward * 10);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject clone;
            clone = Instantiate(miniCannonball, new Vector3(cannonFront.transform.position.x, cannonFront.transform.position.y, cannonFront.transform.position.z), transform.rotation);
            clone.GetComponent<Rigidbody>().velocity = transform.TransformDirection(Vector3.forward * 10);
        }
    }
}
