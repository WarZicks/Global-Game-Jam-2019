using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lac : MonoBehaviour {

    public float timerInput;

    public int fish = 0;
    public int superFish = 0;
    public int gigaFish = 0;

    public bool inTrigger = false;
    public bool getRefCane = false;

    public PlayerMovement my_PM;

    AudioSource soundFishing;

	// Use this for initialization
	void Start () {
        soundFishing = GetComponent<AudioSource>();
        my_PM = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update () {

        if (Input.GetKeyDown(KeyCode.Return) && inTrigger == true && getRefCane == true)
        {
            Fishing();
            StartCoroutine(TimerForInput());
            if (!soundFishing.isPlaying)
            {
                soundFishing.Play();
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




    public void Fishing ()
    {
        if (GameObject.FindGameObjectWithTag("FishingCane") != null)
        {
            if (GameObject.FindGameObjectWithTag("FishingCane").GetComponent<FishingCane>().FishCaneOn == true)
            {
                if (GameObject.FindGameObjectWithTag("FishingCane").GetComponent<FishingCane>().lvl1Fish == true)
                {
                    fish++;
                    Debug.Log(fish);
                }

                else if (GameObject.FindGameObjectWithTag("FishingCane").GetComponent<FishingCane>().lvl2Fish == true)
                {
                    superFish++;
                    Debug.Log(superFish);
                }

                else if (GameObject.FindGameObjectWithTag("FishingCane").GetComponent<FishingCane>().lvl3Fish == true)
                {
                    gigaFish++;
                    Debug.Log(gigaFish);
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
