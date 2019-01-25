using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerHome : MonoBehaviour {

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
            Debug.Log("In");
            GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>().InHome = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Out");
            GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>().InHome = false;
        }
    }
}
