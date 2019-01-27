using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aquarium : MonoBehaviour {

    public float timerInput;

    public bool AquaOn = false;
    public int SeeFish = 0;

    public bool lvl1Time = false;
    public bool lvl2Time = false;
    public bool lvl3Time = false;
    public bool lvl4Time = false;

    public PlayerMovement my_PM;

    public AudioSource songPlayAquarium;

    // Use this for initialization
    void Start () {
        AquaOn = true;
        lvl1Time = true;

        my_PM = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();

        songPlayAquarium = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("SeeFish");
            SeeFish++;
            StartCoroutine(TimerForInput());

            if (!songPlayAquarium.isPlaying)
            {
                songPlayAquarium.Play();
            }

            if (SeeFish == 1)
            {
                if (lvl1Time == true)
                {
                    Debug.Log("NoFish");
                }
                else if (lvl2Time == true)
                {
                    GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>().maxTime += GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>().maxTime * 1.05f;
                    GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>().timeLeft += GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>().timeLeft * 1.05f;
                }
                else if (lvl3Time == true)
                {
                    GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>().maxTime += GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>().maxTime * 1.1f;
                    GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>().timeLeft += GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>().timeLeft * 1.1f;
                }
                else if (lvl4Time == true)
                {
                    GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>().maxTime += GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>().maxTime * 1.2f;
                    GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>().timeLeft += GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>().timeLeft * 1.2f;
                }
            }
        }
    }

    IEnumerator TimerForInput()
    {
        my_PM.disableInput = true;
        yield return new WaitForSeconds(timerInput);
        my_PM.disableInput = false;
    }
}
