using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {

    public GameObject GameManager;

    //Player1
    public GameObject[] p1Lives;
    public Text p1HealthText;
    public Slider p1HealthBar;

    //Player2
    public GameObject[] p2Lives;
    public Text p2HealthText;
    public Slider p2HealthBar;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Lives UI Player1
		if(GameManager.GetComponent<GameStats>().p1ShipLives < 3)
        {
            p1Lives[2].SetActive(false);
        }
        if (GameManager.GetComponent<GameStats>().p1ShipLives < 2)
        {
            p1Lives[1].SetActive(false);
        }
        if (GameManager.GetComponent<GameStats>().p1ShipLives < 1)
        {
            p1Lives[0].SetActive(false);
        }
        //Lives UI Player2
        if (GameManager.GetComponent<GameStats>().p2ShipLives < 3)
        {
            p2Lives[2].SetActive(false);
        }
        if (GameManager.GetComponent<GameStats>().p2ShipLives < 2)
        {
            p2Lives[1].SetActive(false);
        }
        if (GameManager.GetComponent<GameStats>().p2ShipLives < 1)
        {
            p2Lives[0].SetActive(false);
        }

        //Player1 Dock Health
        p1HealthText.text = "" + GameManager.GetComponent<GameStats>().p1DockHealth;
        p1HealthBar.value = GameManager.GetComponent<GameStats>().p1DockHealth;

        //Player2 Dock Health
        p2HealthText.text = "" + GameManager.GetComponent<GameStats>().p2DockHealth;
        p2HealthBar.value = GameManager.GetComponent<GameStats>().p2DockHealth;

    }
}
