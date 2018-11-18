using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    public GameObject port1;
    public GameObject port2;
    public GameObject port3;
    public GameObject ship;

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
    }
}
