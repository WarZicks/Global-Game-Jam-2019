﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TpPlayer : MonoBehaviour {

    public GameObject AreaSpawn;
    public GameObject Player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Player.transform.position = AreaSpawn.transform.position;
        }
    }
}