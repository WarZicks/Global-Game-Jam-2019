using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bed : MonoBehaviour {

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
            Debug.Log("Sleep");
            GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>().timeLeft = GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>().maxTime;
            GameObject.FindGameObjectWithTag("Endurance").GetComponent<Endurance>().enduLeft = GameObject.FindGameObjectWithTag("Endurance").GetComponent<Endurance>().maxEndu;
            GameObject.FindGameObjectWithTag("Aquarium").GetComponent<Aquarium>().SeeFish = 0;
            GameObject.FindGameObjectWithTag("Ballon").GetComponent<Ballon>().PlayBall = 0;
        }
    }
}
