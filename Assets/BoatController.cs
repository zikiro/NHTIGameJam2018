using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatController : MonoBehaviour {

    public float accelerationSpeed = 0.2f;
    public float decelerateSpeed = -0.5f;
    public float maxSpeed = 5.0f;
    private Vector2 input;
    private Vector2 movementVector;
    private Vector2 drag;

    private Rigidbody2D myRB;
    //private string horzAxis = "Horizontal";
    //private string vertAxis = "Vertical";


    public bool player1;

	// Use this for initialization
	void Start ()
    {
        myRB = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
        input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        movementVector += input * accelerationSpeed;
        //drag = -movementVector * 0.4f;

        if(input == Vector2.zero)
        {
            myRB.velocity *= 0.2f;
        }

        Debug.Log(input.magnitude);

        
        //if(myRB.velocity.magnitude > maxSpeed)
        //{
        //    float velOver = myRB.velocity.magnitude - maxSpeed;
        //    Vector2 breakVel = myRB.velocity.normalized * accelerationSpeed;
        //    myRB.AddForce(-breakVel);
        //}

    }

    private void FixedUpdate()
    {
        myRB.AddForce(movementVector);
        movementVector = Vector2.zero;

        //myRB.AddForce(drag);

        if(myRB.velocity.magnitude > maxSpeed)
        {
            //Vector3 newVel = myRB.velocity.normalized * input *
            myRB.velocity *= 0.75f;

        }
    }
}
