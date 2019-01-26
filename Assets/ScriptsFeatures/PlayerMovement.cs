using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed;

    private Rigidbody2D rbPlayer;
    private Vector2 moveVelocity;

    public bool movingLeft = false;
    public bool movingRight = false;
    public bool movingUp = false;
    public bool movingDown = false;
   

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update ()
    {
        //Movement
        #region
        //Move Left
        if (Input.GetKey(KeyCode.Q) && !movingDown && !movingRight && !movingUp)
        {
            transform.position += transform.right * -speed * Time.deltaTime;
            speed = 10;
            movingLeft = true;
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            movingLeft = false;
        }

        //Move Right
        if (Input.GetKey(KeyCode.D) && !movingDown && !movingLeft && !movingUp)
        {
            transform.position += transform.right * speed * Time.deltaTime;
            speed = 10;
            movingRight = true;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            movingRight = false;
        }

        //Move Down 
        if (Input.GetKey(KeyCode.S) && !movingLeft && !movingRight && !movingUp)
        {
            transform.position += transform.up * -speed * Time.deltaTime;
            speed = 10;
            movingDown = true;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            movingDown = false;
        }

        //Move Up
        if (Input.GetKey(KeyCode.Z) && !movingDown && !movingRight && !movingLeft)
        {
            transform.position += transform.up * speed * Time.deltaTime;
            speed = 10;
            movingUp = true;
        }
        if (Input.GetKeyUp(KeyCode.Z))
        {
            movingUp = false;
        }

        #endregion

        if (GameObject.FindGameObjectWithTag("Ballon").GetComponent<Ballon>().BallonOn && GameObject.FindGameObjectWithTag("Endurance").GetComponent<Endurance>().HaveEndu)
        {
            #region
            //Run Left
            if (Input.GetKey(KeyCode.Q) && Input.GetKey(KeyCode.LeftShift) && !movingDown && !movingRight && !movingUp)
            {
                transform.position += transform.right * -speed * Time.deltaTime;
                speed = 20;
                movingLeft = true;
            }
            if (Input.GetKeyUp(KeyCode.Q))
            {
                movingLeft = false;
            }

            //Run Right
            if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.LeftShift) && !movingDown && !movingLeft && !movingUp)
            {
                transform.position += transform.right * speed * Time.deltaTime;
                speed = 20;
                movingRight = true;
            }
            if (Input.GetKeyUp(KeyCode.D))
            {
                movingRight = false;
            }

            //Run Down 
            if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.LeftShift) && !movingLeft && !movingRight && !movingUp)
            {
                transform.position += transform.up * -speed * Time.deltaTime;
                speed = 20;
                movingDown = true;
            }
            if (Input.GetKeyUp(KeyCode.S))
            {
                movingDown = false;
            }

            //Run Up
            if (Input.GetKey(KeyCode.Z) && Input.GetKey(KeyCode.LeftShift) && !movingDown && !movingRight && !movingLeft)
            {
                transform.position += transform.up * speed * Time.deltaTime;
                speed = 20;
                movingUp = true;
            }
            if (Input.GetKeyUp(KeyCode.Z))
            {
                movingUp = false;
            }
            #endregion
        }
    }

    void FixedUpdate()
    {
    }

}
