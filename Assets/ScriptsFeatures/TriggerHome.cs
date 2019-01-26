

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerHome : MonoBehaviour {

    public RessourceManager my_RM;

    public int fishRessource = 0;
    public int superFishRessource = 0;
    public int gigaFishRessource = 0;
    public int woodRessource = 0;


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
            GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>().InHome = true;
            fishRessource += GameObject.FindGameObjectWithTag("Lac").GetComponent<Lac>().fish;
            GameObject.FindGameObjectWithTag("Lac").GetComponent<Lac>().fish = 0;
            superFishRessource += GameObject.FindGameObjectWithTag("Lac").GetComponent<Lac>().superFish;
            GameObject.FindGameObjectWithTag("Lac").GetComponent<Lac>().superFish = 0;
            gigaFishRessource += GameObject.FindGameObjectWithTag("Lac").GetComponent<Lac>().gigaFish;
            GameObject.FindGameObjectWithTag("Lac").GetComponent<Lac>().gigaFish = 0;
            woodRessource += GameObject.FindGameObjectWithTag("RessourceManager").GetComponent<RessourceManager>().wood;
            GameObject.FindGameObjectWithTag("RessourceManager").GetComponent<RessourceManager>().wood = 0;

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

            if (GameObject.FindGameObjectWithTag("Aquarium") != null)
            {
                if (GameObject.FindGameObjectWithTag("Aquarium").GetComponent<Aquarium>().AquaOn == true)
                {
                    if (GameObject.FindGameObjectWithTag("Aquarium").GetComponent<Aquarium>().lvl1Time == true && GameObject.FindGameObjectWithTag("Home").GetComponent<TriggerHome>().fishRessource > 0)
                    {
                        Debug.Log("Lvl2Aquarium");
                        GameObject.FindGameObjectWithTag("Aquarium").GetComponent<Aquarium>().lvl1Time = false;
                        GameObject.FindGameObjectWithTag("Aquarium").GetComponent<Aquarium>().lvl2Time = true;
                    }

                    else if (GameObject.FindGameObjectWithTag("Aquarium").GetComponent<Aquarium>().lvl2Time == true && GameObject.FindGameObjectWithTag("Home").GetComponent<TriggerHome>().superFishRessource > 0)
                    {
                        Debug.Log("Lvl3Aquarium");
                        GameObject.FindGameObjectWithTag("Aquarium").GetComponent<Aquarium>().lvl2Time = false;
                        GameObject.FindGameObjectWithTag("Aquarium").GetComponent<Aquarium>().lvl3Time = true;
                    }

                    else if (GameObject.FindGameObjectWithTag("Aquarium").GetComponent<Aquarium>().lvl3Time == true && GameObject.FindGameObjectWithTag("Home").GetComponent<TriggerHome>().gigaFishRessource > 0)
                    {
                        Debug.Log("Lvl4Aquarium");
                        GameObject.FindGameObjectWithTag("Aquarium").GetComponent<Aquarium>().lvl3Time = false;
                        GameObject.FindGameObjectWithTag("Aquarium").GetComponent<Aquarium>().lvl4Time = true;
                    }

                    else if (GameObject.FindGameObjectWithTag("Aquarium").GetComponent<Aquarium>().lvl4Time == true)
                    {
                        Debug.Log("MaxLvlAquarium");
                    }
                }
            }
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
