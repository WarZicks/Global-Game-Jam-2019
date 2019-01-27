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
    public GreenItem my_GreenItem;
    public UIManager my_UIManager;

    AudioSource soundFishing;

	// Use this for initialization
	void Start () {
        soundFishing = GetComponent<AudioSource>();
        my_PM = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        my_GreenItem = GameObject.FindGameObjectWithTag("GreenItem").GetComponent<GreenItem>();
        my_UIManager = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update () {

        if (my_GreenItem.doRefForCane == true)
        {
            getRefCane = true;
        }

        if (Input.GetKeyDown(KeyCode.Return) && inTrigger == true && getRefCane == true && my_PM.disableInput == false)
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
                    my_PM.fish++;
                    my_UIManager.StandardFishItemUI();
                    Debug.Log(fish);
                }

                else if (GameObject.FindGameObjectWithTag("FishingCane").GetComponent<FishingCane>().lvl2Fish == true)
                {
                    my_PM.superFish++;
                    my_UIManager.RareFishItemUI();
                    Debug.Log(superFish);
                }

                else if (GameObject.FindGameObjectWithTag("FishingCane").GetComponent<FishingCane>().lvl3Fish == true)
                {
                    my_PM.gigaFish++;
                    my_UIManager.GoldFishItemUI();
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
