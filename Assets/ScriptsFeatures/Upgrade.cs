using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade : MonoBehaviour {

    public GameObject upgradeBoardUI;
    public bool myBoardIsUp = false;

    public bool inTrigger;

    public bool upgradeFishingCaneLvl2Done = false;
    public bool upgradeFishingCaneLvl3Done = false;
    public bool upgradeBalloonLvl2Done = false;
    public bool upgradeBalloonLvl3Done = false;
    public bool upgradeAquariumLvl1Done = false;
    public bool upgradeAquariumLvl2Done = false;
    public bool upgradeAquariumLvl3Done = false;
    public bool upgradeAquariumLvl4Done = false;

    public TriggerHome my_Home;
    public FishingCane my_FishingCane;
    public Ballon my_Balloon;
    public Aquarium my_Aquarium;
    public GreenItem my_TakeFishingCane;
    public BlueItem my_TakeBalloon;
    public RedItem my_TakeAquarium;

    // Use this for initialization
    void Start () {
        my_Home = GameObject.FindGameObjectWithTag("Home").GetComponent<TriggerHome>();
        my_TakeFishingCane = GameObject.FindGameObjectWithTag("GreenItem").GetComponent<GreenItem>();
        my_TakeBalloon = GameObject.FindGameObjectWithTag("BlueItem").GetComponent<BlueItem>();
        my_TakeAquarium = GameObject.FindGameObjectWithTag("RedItem").GetComponent<RedItem>();

        /*my_Balloon = GameObject.FindGameObjectWithTag("Ballon").GetComponent<Ballon>();
        my_Aquarium = GameObject.FindGameObjectWithTag("Aquarium").GetComponent<Aquarium>();*/
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
            if (my_TakeFishingCane.doRefForCane == true)
            { 
                my_FishingCane = GameObject.FindGameObjectWithTag("FishingCane").GetComponent<FishingCane>();
            }
            if (my_TakeBalloon.doRefForBalloon == true)
            {
                my_Balloon = GameObject.FindGameObjectWithTag("Ballon").GetComponent<Ballon>();
            }
            if (my_TakeAquarium.doRefForCane == true)
            {
                my_Aquarium = GameObject.FindGameObjectWithTag("Aquarium").GetComponent<Aquarium>();
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

    //FishingCane Upgrade
    public void UpgradeFishingCaneLVL2()
    {
        if (myBoardIsUp == true && my_Home.woodRessource >= 3 && my_FishingCane.lvl1Fish == true && upgradeFishingCaneLvl2Done == false)
        {
            my_FishingCane.lvl1Fish = false;
            my_FishingCane.lvl2Fish = true;
            upgradeFishingCaneLvl2Done = true;
        }
    }
    public void UpgradeFishingCaneLVL3()
    {
        if (myBoardIsUp == true && my_Home.woodRessource >= 5 && my_FishingCane.lvl2Fish == true && upgradeFishingCaneLvl3Done == false)
        {
            my_FishingCane.lvl2Fish = false;
            my_FishingCane.lvl3Fish = true;
            upgradeFishingCaneLvl3Done = true;
        }
    }

    //Balloon Upgrade
    public void UpgradeBalloonLVL2()
    {
        if (myBoardIsUp == true && my_Home.woodRessource >= 3 && my_Balloon.lvl1Endu == true && upgradeBalloonLvl2Done == false)
        {
            my_Balloon.lvl1Endu = false;
            my_Balloon.lvl2Endu = true;
            upgradeBalloonLvl2Done = true;
        }
    }
    public void UpgradeBalloonLVL3()
    {
        if (myBoardIsUp == true && my_Home.woodRessource >= 1 && my_Balloon.lvl2Endu == true && upgradeBalloonLvl3Done == false)
        {
            my_Balloon.lvl2Endu = false;
            my_Balloon.lvl3Endu = true;
            upgradeBalloonLvl3Done = true;
        }
    }

    public void ExitBoard()
    {
        myBoardIsUp = false;
        upgradeBoardUI.SetActive(false);
    }

}
