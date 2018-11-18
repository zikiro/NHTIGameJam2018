using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour {
    public GameObject gameManager;
	// Use this for initialization
	void Start () {
        gameManager = GameObject.FindGameObjectWithTag("GameController");
	}
	
	// Update is called once per frame
	void Update () {
        if(this.gameObject.tag == "AIShip")
        {
            transform.Translate(Vector3.right * .09f);
        } else {
            transform.Translate(Vector3.left * .09f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if(this.gameObject.tag == "AIShip")
        {
            if (other.tag == "Player")
            {
                Destroy(this.gameObject);
                gameManager.GetComponent<GameStats>().p2ShipLives--;
            }

            if (other.tag == "Dock")
            {
                Debug.Log("hit!");
                Destroy(this.gameObject);
                gameManager.GetComponent<GameStats>().p2DockHealth -= 20;
            }
        } else {
            if (other.tag == "Dock2")
            {
                Debug.Log("hit!");
                Destroy(this.gameObject);
                gameManager.GetComponent<GameStats>().p1DockHealth -= 20;
            }
            if (other.tag == "Player2")
            {
                Destroy(this.gameObject);
                gameManager.GetComponent<GameStats>().p1ShipLives--;
            }
        }

    }

}
