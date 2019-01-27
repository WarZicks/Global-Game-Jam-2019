using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Animator animator;

    public float speed;

    private Rigidbody2D rbPlayer;
    private Vector2 moveVelocity;

    public bool movingLeft = false;
    public bool movingRight = false;
    public bool movingUp = false;
    public bool movingDown = false;

    public int fish = 0;
    public int superFish = 0;
    public int gigaFish = 0;

    public bool disableInput = false;

    public Vector2 lastDirection;

    // Use this for initialization
    void Start () {
        lastDirection = Vector2.zero;
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Movement
        #region
        //Move Left
        if (Input.GetKey(KeyCode.Q) && !movingDown && !movingRight && !movingUp && !disableInput)
        {
            transform.position += transform.right * -speed * Time.deltaTime;
            speed = 5;
            movingLeft = true;
            animator.SetFloat("Speed", 1);
            animator.SetBool("FaceLeft", true);
            animator.SetBool("FaceRight", false);
            animator.SetBool("FaceUp", false);
            animator.SetBool("FaceDown", false);
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            movingLeft = false;
            animator.SetFloat("Speed", 0);
            lastDirection = new Vector2(-1, 0);
        }

        //Move Right
        if (Input.GetKey(KeyCode.D) && !movingDown && !movingLeft && !movingUp && !disableInput)
        {
            transform.position += transform.right * speed * Time.deltaTime;
            speed = 5;
            movingRight = true;
            animator.SetFloat("Speed", 1);
            animator.SetBool("FaceLeft", false);
            animator.SetBool("FaceRight", true);
            animator.SetBool("FaceUp", false);
            animator.SetBool("FaceDown", false);
            lastDirection = new Vector2(1, 0);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            movingRight = false;
            animator.SetFloat("Speed", 0);
        }

        //Move Down 
        if (Input.GetKey(KeyCode.S) && !movingLeft && !movingRight && !movingUp && !disableInput)
        {
            transform.position += transform.up * -speed * Time.deltaTime;
            speed = 5;
            movingDown = true;
            animator.SetFloat("Speed", 1);
            animator.SetBool("FaceLeft", false);
            animator.SetBool("FaceRight", false);
            animator.SetBool("FaceUp", false);
            animator.SetBool("FaceDown", true);
            lastDirection = new Vector2(0, -1);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            movingDown = false;
            animator.SetFloat("Speed", 0);
        }

        //Move Up
        if (Input.GetKey(KeyCode.Z) && !movingDown && !movingRight && !movingLeft && !disableInput)
        {
            transform.position += transform.up * speed * Time.deltaTime;
            speed = 5;
            movingUp = true;
            animator.SetFloat("Speed", 1);
            animator.SetBool("FaceLeft", false);
            animator.SetBool("FaceRight", false);
            animator.SetBool("FaceUp", true);
            animator.SetBool("FaceDown", false);
            lastDirection = new Vector2(0, 1);
        }
        if (Input.GetKeyUp(KeyCode.Z))
        {
            movingUp = false;
            animator.SetFloat("Speed", 0);
        }

        #endregion
        if (GameObject.FindGameObjectWithTag("Ballon") != null)
        {
            if (GameObject.FindGameObjectWithTag("Ballon").GetComponent<Ballon>().BallonOn && GameObject.FindGameObjectWithTag("Endurance").GetComponent<Endurance>().HaveEndu)
            {
                #region
                //Run Left
                if (Input.GetKey(KeyCode.Q) && Input.GetKey(KeyCode.LeftShift) && !movingDown && !movingRight && !movingUp && !disableInput)
                {
                    transform.position += transform.right * -speed * Time.deltaTime;
                    speed = 10;
                    movingLeft = true;
                }
                if (Input.GetKeyUp(KeyCode.Q))
                {
                    movingLeft = false;
                }

                //Run Right
                if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.LeftShift) && !movingDown && !movingLeft && !movingUp && !disableInput)
                {
                    transform.position += transform.right * speed * Time.deltaTime;
                    speed = 10;
                    movingRight = true;
                }
                if (Input.GetKeyUp(KeyCode.D))
                {
                    movingRight = false;
                }

                //Run Down 
                if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.LeftShift) && !movingLeft && !movingRight && !movingUp && !disableInput)
                {
                    transform.position += transform.up * -speed * Time.deltaTime;
                    speed = 10;
                    movingDown = true;
                }
                if (Input.GetKeyUp(KeyCode.S))
                {
                    movingDown = false;
                }

                //Run Up
                if (Input.GetKey(KeyCode.Z) && Input.GetKey(KeyCode.LeftShift) && !movingDown && !movingRight && !movingLeft && !disableInput)
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
            }
        }

    }

    public void UpgradeAquarium()
    {
        if (GameObject.FindGameObjectWithTag("Aquarium") != null)
        {
            if (GameObject.FindGameObjectWithTag("Aquarium").GetComponent<Aquarium>().AquaOn == true)
            {
                if (Input.GetKeyDown(KeyCode.O) && GameObject.FindGameObjectWithTag("Aquarium").GetComponent<Aquarium>().lvl1Time == true && GameObject.FindGameObjectWithTag("Home").GetComponent<TriggerHome>().fishRessource>0)
                {
                    Debug.Log("Lvl2Aquarium");
                    GameObject.FindGameObjectWithTag("Aquarium").GetComponent<Aquarium>().lvl1Time = false;
                    GameObject.FindGameObjectWithTag("Aquarium").GetComponent<Aquarium>().lvl2Time = true;
                }

                else if (Input.GetKeyDown(KeyCode.O) && GameObject.FindGameObjectWithTag("Aquarium").GetComponent<Aquarium>().lvl2Time == true && GameObject.FindGameObjectWithTag("Home").GetComponent<TriggerHome>().superFishRessource > 0)
                {
                    Debug.Log("Lvl3Aquarium");
                    GameObject.FindGameObjectWithTag("Aquarium").GetComponent<Aquarium>().lvl2Time = false;
                    GameObject.FindGameObjectWithTag("Aquarium").GetComponent<Aquarium>().lvl3Time = true;
                }

                else if (Input.GetKeyDown(KeyCode.O) && GameObject.FindGameObjectWithTag("Aquarium").GetComponent<Aquarium>().lvl3Time == true && GameObject.FindGameObjectWithTag("Home").GetComponent<TriggerHome>().gigaFishRessource > 0)
                {
                    Debug.Log("Lvl4Aquarium");
                    GameObject.FindGameObjectWithTag("Aquarium").GetComponent<Aquarium>().lvl3Time = false;
                    GameObject.FindGameObjectWithTag("Aquarium").GetComponent<Aquarium>().lvl4Time = true;
                }

                else if (Input.GetKeyDown(KeyCode.O) && GameObject.FindGameObjectWithTag("Aquarium").GetComponent<Aquarium>().lvl4Time == true)
                {
                    Debug.Log("MaxLvlAquarium");
                }
            }
        }
    }

}
