﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballon : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Play");
            GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>().maxTime++;
            GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>().timeLeft++;
        }
    }
}
