using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public int Vert_PlayerSpeed = 1;
    public int Horz_PlayerSpeed = 1;
    public int max_speed = 1;
    public float smoothingTime = 1;
    private Rigidbody2D myRB = null;
    private Vector2 moveInput;
    private Vector2 moveVelocity;



    // Use this for initialization
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        moveVelocity.x = moveInput.x * Horz_PlayerSpeed;
        moveVelocity.y = moveInput.y * Vert_PlayerSpeed;
    }

    private void FixedUpdate()
    {
        

        //if (myRB.velocity.magnitude <= max_speed)
        //{
        //    myRB.AddForce(moveVelocity);
        //}
        if (moveVelocity == Vector2.zero)
        {
            myRB.velocity = Vector2.Lerp(myRB.velocity, Vector2.zero, smoothingTime * Time.deltaTime);
        }
        else if (myRB.velocity.magnitude <= max_speed && moveVelocity != Vector2.zero)
        {
            myRB.AddForce(moveVelocity);
        }


        //if(moveVelocity == Vector2.zero)
        //{
        //    myRB.velocity = Vector2.SmoothDamp(myRB.velocity, Vector2.zero, myRB.velocity, )
        //}
        //else
        //{
        //    myRB.velocity = moveVelocity;
        //}

        Debug.Log(moveVelocity);
    }

}