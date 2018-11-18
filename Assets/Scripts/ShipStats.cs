using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipStats : MonoBehaviour {

    private int health;

	// Use this for initialization
	void Start () {
        health = 100;
	}
	
	// Update is called once per frame
	void Update () {
		if(health < 1)
        {
            Destroy(this.gameObject);
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("inside!");

        if(other.tag == "MiniCannonball")
        {
            health -= 50;
            Destroy(other.gameObject);
        }
        if (other.tag == "Cannonball")
        {
            health -= 100;
            Destroy(other.gameObject);
        }
    }

}
