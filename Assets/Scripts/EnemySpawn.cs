using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    public GameObject port1;
    public GameObject port2;
    public GameObject port3;
    public GameObject ship;

    public GameObject p2_port1;
    public GameObject p2_port2;
    public GameObject p2_port3;
    public GameObject p2_ship;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.Alpha6))
        {
            Instantiate(ship, port1.transform.position, transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            Instantiate(ship, port2.transform.position, transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            Instantiate(ship, port3.transform.position, transform.rotation);
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            Instantiate(p2_ship, p2_port1.transform.position, transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            Instantiate(p2_ship, p2_port2.transform.position, transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            Instantiate(p2_ship, p2_port3.transform.position, transform.rotation);
        }
    }
}
