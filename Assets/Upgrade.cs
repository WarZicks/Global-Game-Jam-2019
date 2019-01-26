using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade : MonoBehaviour {

    public GameObject upgradeBoardUI;
    public bool myBoardIsUp = false;

    public bool inTrigger;

    public TriggerHome my_Home;
    public FishingCane my_FishingCane;
    public GreenItem my_GreenItem;

	// Use this for initialization
	void Start () {
        my_Home = GameObject.FindGameObjectWithTag("Home").GetComponent<TriggerHome>();
        my_GreenItem = GameObject.FindGameObjectWithTag("GreenItem").GetComponent<GreenItem>();
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Return) && inTrigger == true)
        {
            upgradeBoardUI.SetActive(true);
            myBoardIsUp = true;
        }

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (my_GreenItem.doRefForCane == true)
            { 
                my_FishingCane = GameObject.FindGameObjectWithTag("FishingCane").GetComponent<FishingCane>();
            }

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

    public void UpgradeFishingCaneLVL2()
    {
        if (myBoardIsUp == true && my_Home.woodRessource >= 3 && my_FishingCane.lvl1Fish == true)
        {
            my_FishingCane.lvl1Fish = false;
            my_FishingCane.lvl2Fish = true;
        }
    }

    public void UpgradeFishingCaneLVL3()
    {
        if (myBoardIsUp == true && my_Home.woodRessource >= 5 && my_FishingCane.lvl2Fish == true)
        {
            my_FishingCane.lvl2Fish = false;
            my_FishingCane.lvl3Fish = true;
        }
    }

    public void ExitBoard()
    {
        myBoardIsUp = false;
        upgradeBoardUI.SetActive(false);
    }

}
