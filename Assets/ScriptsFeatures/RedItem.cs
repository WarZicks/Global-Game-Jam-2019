﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedItem : MonoBehaviour {

    public bool redCube = false;

    public RessourceManager my_RM;

    // Use this for initialization
    void Start () {
        my_RM = GameObject.FindGameObjectWithTag("RessourceManager").GetComponent<RessourceManager>();
	}
	
	// Update is called once per frame
	void Update () {
        if (redCube == true && Input.GetKeyDown(KeyCode.Return))
        {
            my_RM.AddRedItem();
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            redCube = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            redCube = false;
        }
    }
}