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
        transform.Translate(Vector3.right * .02f);
    }

    private void OnTriggerEnter(Collider other)
    {
        

        if (other.tag == "Dock")
        {
            Debug.Log("hit!");
            Destroy(this.gameObject);
            gameManager.GetComponent<GameStats>().p2DockHealth -= 20;
        }
    }

}
