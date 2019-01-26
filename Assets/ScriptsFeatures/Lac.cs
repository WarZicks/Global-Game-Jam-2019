using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lac : MonoBehaviour {

    public int fish = 0;
    public int superFish = 0;
    public int gigaFish = 0;

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
            Fishing();
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
}
