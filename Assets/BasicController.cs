using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicController : MonoBehaviour
{

    private Vector2 moveInput = Vector2.zero;
    private Vector2 moveVelocity = Vector2.zero;
    private float playerSpeed = 0;

    private Rigidbody2D myRB = null;

    // Use this for initialization
    void Start ()
    {
        myRB = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        moveVelocity = moveInput * playerSpeed;
    }

    private void FixedUpdate()
    {
        myRB.velocity = moveVelocity;
    }
}
