using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStats : MonoBehaviour {

    public int p1ShipLives;
    public int p1DockHealth;
    public GameObject player1Ship;

    public int p2ShipLives;
    public int p2DockHealth;
    public GameObject player2Ship;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(p1ShipLives < 1)
        {
            Destroy(player1Ship.gameObject);
        }
        if(p2ShipLives < 1)
        {
            Destroy(player2Ship.gameObject);
        }
	}
}
