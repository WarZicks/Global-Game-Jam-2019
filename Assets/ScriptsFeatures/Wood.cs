using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood : MonoBehaviour {

    public bool inTrigger = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Return) && inTrigger == true)
        {
            GameObject.FindGameObjectWithTag("RessourceManager").GetComponent<RessourceManager>().wood++;
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            inTrigger = true;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            inTrigger = false;
        }
    }
}
