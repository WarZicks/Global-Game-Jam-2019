using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerHome : MonoBehaviour {

    public RessourceManager my_RM;

    // Use this for initialization
    void Start () {

        my_RM = GameObject.FindGameObjectWithTag("RessourceManager").GetComponent<RessourceManager>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (my_RM.redItem >= 1)
            {
                my_RM.Aquarium.SetActive(true);
                my_RM.redItem = 0;
            }
            if (my_RM.blueItem >= 1)
            {
                my_RM.Ballon.SetActive(true);
                my_RM.blueItem = 0;
            }
            if (my_RM.greenItem >= 1)
            {
                my_RM.FishingCane.SetActive(true);
                my_RM.greenItem = 0;
            }
        }

        if (collision.gameObject.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>().InHome = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>().InHome = false;
        }
    }
}
