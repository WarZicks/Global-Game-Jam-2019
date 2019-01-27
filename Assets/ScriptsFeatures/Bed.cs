using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bed : MonoBehaviour {

    public float timerInput;

    public bool inTrigger = false;

    public AudioSource soundSleep;

    public PlayerMovement my_PM;

    public Animator animFade;

	// Use this for initialization
	void Start () {
        soundSleep = GetComponent<AudioSource>();
        my_PM = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Return) && inTrigger == true && my_PM.disableInput == false)
        {
            Debug.Log("Sleep");
            GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>().timeLeft = GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>().maxTime;
            if (GameObject.FindGameObjectWithTag("Endurance").GetComponent<Endurance>().CanRun)
            {
                GameObject.FindGameObjectWithTag("Endurance").GetComponent<Endurance>().enduLeft = GameObject.FindGameObjectWithTag("Endurance").GetComponent<Endurance>().maxEndu;
            }
            soundSleep.Play();
            StartCoroutine(TimerForInput());

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

    IEnumerator TimerForInput()
    {
        my_PM.disableInput = true;
        animFade.SetBool("DoFade", true);
        yield return new WaitForSeconds(timerInput);
        animFade.SetBool("DoFade", false);
        my_PM.disableInput = false;
    }
}
