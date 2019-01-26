using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bed : MonoBehaviour {

    public bool inTrigger = false;

    public AudioSource soundSleep;

	// Use this for initialization
	void Start () {
        soundSleep = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Return) && inTrigger == true)
        {
            Debug.Log("Sleep");
            GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>().timeLeft = GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>().maxTime;
            GameObject.FindGameObjectWithTag("Endurance").GetComponent<Endurance>().enduLeft = GameObject.FindGameObjectWithTag("Endurance").GetComponent<Endurance>().maxEndu;
            soundSleep.Play();

            if (GameObject.FindGameObjectWithTag("Aquarium") != null)
            {
                GameObject.FindGameObjectWithTag("Aquarium").GetComponent<Aquarium>().SeeFish = 0;
            }
            if (GameObject.FindGameObjectWithTag("Ballon") != null)
            {
                GameObject.FindGameObjectWithTag("Ballon").GetComponent<Ballon>().PlayBall = 0;
            }
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
